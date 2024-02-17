using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using UGCore;

namespace UGSyncUI {

    public partial class MainForm : MetroFramework.Forms.MetroForm {
        /// const
        private const int DELAY_TIME = 3;
        private const int MINUTE_TO_MILISEC = 60 * 1000;
        private const int HOUR_TO_MILISEC = 60 * MINUTE_TO_MILISEC;
        /// static

        /// textbox
        private string connString = "";
        private string mySqlConn = "";
        private string webUserName = "";
        private string webUserPass = "";

        private string priceStock_xTop = "";
        private string priceStock_url = "";
        private string priceStock_xEr = "";

        private string product_TopX = "";
        private string product_url = "";
        private bool product_includeImage = false;

        private string order_DaysAgo = "";
        private string order_url = "";
        private bool isWebAdressBaseOnUpdateDate = true;
        ///  global
        private static volatile bool _isTimerTicked = false;
        private System.Timers.Timer timerFiyatStok; /// execute after order
        private System.Timers.Timer timerOzelKod;
        private System.Timers.Timer timerOrder;
        private List<Task> tasks;

        public MainForm() {
            InitializeComponent();

            textBoxSqlconn.Text = Functions.GetConnString("ms_sql");
            textBoxMySqlConn.Text = Functions.GetConnString("my_sql");

            setUpTextBoxes();

            Log.deleteYesterdayLog();

            timerFiyatStok = new System.Timers.Timer();
            timerOzelKod = new System.Timers.Timer();
            timerOrder = new System.Timers.Timer();
            tasks = new List<Task>();

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            setUpTimers();
            setUpUseNotify();
            //setUpDateTimePicker();

            OnTimedEventTimerMinute(new object(), null);

            tabPage1.Select();
            tabTheControl.SelectedTab = tabPage1;
            metroProgressSpinner1.Visible = false;
            //            /// ///
            //            /// WCF host // no need
            //            /// ///
            //            host = new ServiceHost(typeof(UGSyncWCF));
            //            //host.Open();
            //#if DEBUG
            //#else
            //            host.Open();
            //#endif
#if DEBUG
            metroButton2.Visible = true;
#endif
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {          
            try {
                if (Object.ReferenceEquals(typeof(NotifyIcon), notifyIcon1)) {
                    notifyIcon1.Visible = false;
                }
                ///stop at closing
                //await Task.WhenAll(tasks);

                /// Wait for all the tasks to finish.
                Task.WaitAll(tasks.ToArray());

                /// We should never get to this point
                Console.WriteLine("WaitAll() has not thrown exceptions. THIS WAS NOT EXPECTED.");
            }
            catch (AggregateException) { }

            /// no need
            //if (host.State == CommunicationState.Opened) {
            //    /// stop WCF host
            //    host.Close();
            //}
        }

        #region Timers
        /// Timers
        private void setUpTimers() {
            /// timers
            System.Timers.Timer timerHour = new System.Timers.Timer();
            timerHour.SynchronizingObject = this;
            timerHour.Interval = HOUR_TO_MILISEC;
            timerHour.Enabled = true;
            timerHour.AutoReset = true;
            timerHour.Elapsed += new ElapsedEventHandler(OnTimedEventtimerHour);

            System.Timers.Timer timerMinute = new System.Timers.Timer();
            timerMinute.SynchronizingObject = this;
            timerMinute.Interval = MINUTE_TO_MILISEC;
            timerMinute.Enabled = true;
            timerMinute.AutoReset = true;
            timerMinute.Elapsed += new ElapsedEventHandler(OnTimedEventTimerMinute);

            timerFiyatStok.SynchronizingObject = this;
            timerFiyatStok.Interval = Convert.ToInt32(textBoxInterval_FiyatStok.Text) * MINUTE_TO_MILISEC;

            timerFiyatStok.Enabled = true;
            timerFiyatStok.AutoReset = true;
            timerFiyatStok.Elapsed += new ElapsedEventHandler(OnTimedEventFiyatStok);

            timerOzelKod.SynchronizingObject = this;
            timerOzelKod.Interval = Convert.ToInt32(textBoxInterval_OzelKod.Text) * MINUTE_TO_MILISEC;
            timerOzelKod.Enabled = true;
            timerOzelKod.AutoReset = true;
            timerOzelKod.Elapsed += new ElapsedEventHandler(OnTimedEventOzelKod);

            timerOrder.SynchronizingObject = this;
            timerOrder.Interval = Convert.ToInt32(textBoxInterval_Order.Text) * MINUTE_TO_MILISEC;
            timerOrder.Enabled = true;
            timerOrder.AutoReset = true;
            timerOrder.Elapsed += new ElapsedEventHandler(OnTimedEventOrder);
        }

        private async void OnTimedEventtimerHour(object source, ElapsedEventArgs e) {
            //UGLog uLog = new UGLog();
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            Log.deleteYesterdayLog();

            /// once an hour send all
            labelInfo.Invoke(() => labelInfo.Text = "Saatlik Timer Çalışıyor");
            if (!_isTimerTicked) {
                _isTimerTicked = true;
                /// saate bir full stack gönder -> timerla full gönder
                //Console.WriteLine("{0}->{1}", DateTime.Now.ToString(), "fiyatStok");
                //tasks.Add(UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME, true));
                //await Task.Run(() => UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME, true));
                /// saate bir yazar gönder
                await Task.Run(() => UGSync_Yazar.sendYazarToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME));
                /// saatte bir irsaliye ekine bak
                await Task.Run(() => UGSync_ReceiptAttachment.FindNullAttachments(order_url, webUserName, webUserPass, 3, isWebAdressBaseOnUpdateDate));
                /// saate bir xleri sil
                await Task.Run(() => UGSync_Product.findXAndDelete());
            }

            _isTimerTicked = false;
        }

        private void OnTimedEventTimerMinute(object source, ElapsedEventArgs e) {
            if (!checkBoxStopAll.Checked && !checkBoxStopFiyatStok.Checked && !checkBoxStopOzelKod.Checked && !checkBoxStopOrder.Checked) {
                if (DateTime.Now.TimeOfDay > dateTimePicker_FiyatStokLeft.Value.TimeOfDay && dateTimePicker_FiyatStokRight.Value.TimeOfDay > DateTime.Now.TimeOfDay) {
                    timerFiyatStok.Start();
                }
                else {
                    timerFiyatStok.Stop();
                }
                if (DateTime.Now.TimeOfDay > dateTimePicker_OzelKodLeft.Value.TimeOfDay && dateTimePicker_OzelKodRight.Value.TimeOfDay > DateTime.Now.TimeOfDay) {
                    timerOzelKod.Start();
                }
                else {
                    timerOzelKod.Stop();
                }
                if (DateTime.Now.TimeOfDay > dateTimePicker_OrderLeft.Value.TimeOfDay && dateTimePicker_OrderRight.Value.TimeOfDay > DateTime.Now.TimeOfDay) {
                    timerOrder.Start();
                }
                else {
                    timerOrder.Stop();
                }
            }

        }

        private async void OnTimedEventFiyatStok(object source, ElapsedEventArgs e) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            labelInfo.Invoke(() => labelInfo.Text = "FiyatStok Çalışıyor");
            if (!_isTimerTicked) {
                _isTimerTicked = true;
                Console.WriteLine("{0}->{1}", DateTime.Now.ToString(), "fiyatStok");
                var priceStock = UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME);
                tasks.Add(priceStock);
                await Task.Run(() => priceStock);
            }
            _isTimerTicked = false;
        }

        private async void OnTimedEventOzelKod(object source, ElapsedEventArgs e) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            labelInfo.Invoke(() => labelInfo.Text = "OzelKod Çalışıyor");
            if (!_isTimerTicked) {
                _isTimerTicked = true; 
                Console.WriteLine("{0}->{1}", DateTime.Now.ToString(), "ozelKod");
                var specialCode = UGSync_Product.sendToWebsite(product_TopX, product_includeImage, product_url, connString, webUserName, webUserPass, DELAY_TIME);
                tasks.Add(specialCode);
                await Task.Run(() => specialCode);
            }
            PrintObj.CleanRazorTemp();
            _isTimerTicked = false;
        }

        private async void OnTimedEventOrder(object source, ElapsedEventArgs e) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            labelInfo.Invoke(() => labelInfo.Text = "Order Çalışıyor");
            if (!_isTimerTicked) {
                _isTimerTicked = true;
                Console.WriteLine("{0}->{1}", DateTime.Now.ToString(), "order");
                var order = UGSync_Order.sendOrdersToSql(order_DaysAgo, order_url, connString, mySqlConn, webUserName, webUserPass, DELAY_TIME, isWebAdressBaseOnUpdateDate);
                tasks.Add(order);
                await Task.Run(() => order);
            }
            _isTimerTicked = false;

            //var delayTask =  Task.Delay(1000);

            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            //labelInfo.Invoke(() => labelInfo.Text = "FiyatStok Çalışıyor");
            //if (!_isTimerTicked) {
            //    _isTimerTicked = true;
            //    Console.WriteLine("{0}->{1}", DateTime.Now.ToString(), "fiyatStok");
            //    var priceStock = UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME);
            //    tasks.Add(priceStock);
            //    await Task.Run(() => priceStock);
            //}
            //await delayTask;
            //_isTimerTicked = false;
        }
        #endregion

        #region button
        /// Buttons
        private void setUpTextBoxes() {
            if (textBoxSqlconn.Text == "") {
                connString = Functions.GetConnString("ms_sql");
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxSqlconn boş olamaz. ->" + connString);
            }
            else {
                connString = textBoxSqlconn.Text;
            }

            if (textBoxMySqlConn.Text == "") {
                mySqlConn = Functions.GetConnString("my_sql");
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxMySqlConn boş olamaz. ->" + mySqlConn);
            }
            else {
                mySqlConn = textBoxMySqlConn.Text;
            }

            if (textBoxWebUsername.Text == "") {
                webUserName = @"yourPass";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxWebUsername boş olamaz -> " + webUserName);
            }
            else {
                webUserName = textBoxWebUsername.Text;
            }

            if (textBoxWebUserPass.Text == "") {
                webUserPass = @"yourPass";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxWebUserPass boş olamaz -> " + webUserPass);
            }
            else {
                webUserPass = textBoxWebUserPass.Text;
            }

            if (textBoxPriceStock_xTop.Text == "") {
                priceStock_xTop = "10000";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxPriceStock_xTop Boş olamaz -> " + priceStock_xTop.ToString());
            }
            else {
                priceStock_xTop = textBoxPriceStock_xTop.Text;
            }
            ///pricestock
            if (textBoxPriceStock_xEr.Text == "") {
                priceStock_xEr = "1000";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxPriceStock_xEr boş olamaz -> " + priceStock_xEr);
            }
            else {
                priceStock_xEr = textBoxPriceStock_xEr.Text;
            }

            if (textBoxWebSitePostAddress.Text == "") {
                priceStock_url = @"https://www.uzaktangelir.com/extensions/sentez/index.php";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxWebSitePostAddress Boş olamaz -> " + priceStock_url);
            }
            else {
                priceStock_url = textBoxWebSitePostAddress.Text;
            }

            ///product
            if (textBoxProduct_TopX.Text == "") {
                product_TopX = "5";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxProduct_TopX Boş olamaz ->" + product_TopX.ToString());
            }
            else {
                product_TopX = textBoxProduct_TopX.Text;
            }

            product_url = @"https://www.uzaktangelir.com/extensions/sentez/index.php";

            if (metroToggleResim.Checked)
                product_includeImage = true;
            else
                product_includeImage = false;

            ///order
            if (textBoxOrder_DaysAgo.Text == "") {
                order_DaysAgo = "7";
                labelInfo2.Invoke(() => labelInfo2.Text = "textBoxProduct_TopX Boş olamaz ->" + order_DaysAgo.ToString());
            }
            else {
                order_DaysAgo = textBoxOrder_DaysAgo.Text;
            }
            
            if (metroText_OrderUrl.Text == "") {
                order_url = "https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0";
                labelInfo2.Invoke(() => labelInfo2.Text = "metroText_OrderUrl Boş olamaz ->" + order_url.ToString());
            }
            else {
                order_url = metroText_OrderUrl.Text;
            }

            if (metroCheckBox_createdDate.Checked) {
                isWebAdressBaseOnUpdateDate = false;
            }
            //order_url = @"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0";
            //order_url = @"https://www.uzaktangelir.com/extensions/ordersExportData/orders.php?orders=1&id=0";
        }

        private async void PriceStock_Click(object sender, EventArgs e) { ////////////////////////////////////////////////////////////////////////////// FiyatStok / PriceStock
            labelInfo.Invoke(() => labelInfo.Text = "FiyatStok Çalışıyor");
            await Task.Run(() => UGSync_PriceStock.sendPriceStockToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME));
            _isTimerTicked = false;
        }


        private async void Product_Click(object sender, EventArgs e) { ///////////////////////////////////////////////////////////////////////////// OzelKod / Product
            labelInfo.Invoke(() => labelInfo.Text = "Özel Kod-Ürünler Çalışıyor");
            await Task.Run(() => UGSync_Product.sendToWebsite(product_TopX, product_includeImage, product_url, connString, webUserName, webUserPass, DELAY_TIME));
            //ozelKod();
            _isTimerTicked = false;
        }

        private async void Order_Click(object sender, EventArgs e) {///////////////////////////////////////////////////////////////////////////////// Siparis / Order 
            labelInfo.Invoke(() => labelInfo.Text = "Siparis Çalışıyor");
            await Task.Run(() => UGSync_Order.sendOrdersToSql(order_DaysAgo, order_url, connString, mySqlConn, webUserName, webUserPass, DELAY_TIME, isWebAdressBaseOnUpdateDate));
            //orderSQLservice();
            _isTimerTicked = false;
        }
        private async void metroButtonYazar_Click(object sender, EventArgs e) {
            labelInfo.Invoke(() => labelInfo.Text = "Yazar Çalışıyor");
            await Task.Run(() => UGSync_Yazar.sendYazarToWebSite(priceStock_xTop, priceStock_xEr, priceStock_url, connString, webUserName, webUserPass, DELAY_TIME));
            _isTimerTicked = false;
        }

        private async void metroButtonEkler_Click(object sender, EventArgs e) {
            labelInfo.Invoke(() => labelInfo.Text = "Sipariş Ekler Çalışıyor");
            await Task.Run(() => UGSync_ReceiptAttachment.FindNullAttachments(order_url, webUserName, webUserPass, 3, isWebAdressBaseOnUpdateDate));
            _isTimerTicked = false;
        }


        private  void metroButtonDefault_Click(object sender, EventArgs e) {
            OnTimedEventOrder(new object(), null);
        }

        #endregion

        #region formUtilities
        ///Utilities
        private void TextBoxDaysAgo_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxXer_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBoxProductTimeOut_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e) {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void Form1_Resize(object sender, EventArgs e) {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void CheckBoxStopFiyatStok_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxStopFiyatStok.Checked) {
                timerFiyatStok.Stop();
                labelInfo.Invoke(() => labelInfo.Text = "Fiyat/Stok aktarma işlemi durdu.");
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Text = "Fiyat/Stok Zamanlayıcısını Başlat");
                toolStripMenuItem_stopFiyatStok.Text = "Fiyat/Stok Başlat";
            }
            else {
                timerFiyatStok.Start();
                labelInfo.Invoke(() => labelInfo.Text = "Fiyat/Stok aktarma işlemi başladı.");
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Text = "Fiyat/Stok Zamanlayıcısını Durdur");
                toolStripMenuItem_stopFiyatStok.Text = "Fiyat/Stok Durdur";
            }
        }

        private void CheckBoxStopOzelKod_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxStopOzelKod.Checked) {
                timerOzelKod.Stop();
                labelInfo.Invoke(() => labelInfo.Text = "Ürün aktarma işlemi durdu.");
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Text = "Ürün Zamanlayıcısını Başlat");
                toolStripMenuItem_stopOzelKod.Text = "Ürün Başlat";
            }
            else {
                timerOzelKod.Start();
                labelInfo.Invoke(() => labelInfo.Text = "Ürün aktarma işlemi başladı.");
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Text = "Ürün Zamanlayıcısını Durdur");
                toolStripMenuItem_stopOzelKod.Text = "Ürün Durdur";
            }
        }

        private void CheckBoxStopOrder_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxStopOrder.Checked) {
                timerOrder.Stop();
                labelInfo.Invoke(() => labelInfo.Text = "Sipariş çekme işlemi durdu.");
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Text = "Sipariş Zamanlayıcısını Başlat");
                toolStripMenuItem_stopOrder.Text = "Sipariş Başlat";
            }
            else {
                timerOrder.Start();
                labelInfo.Invoke(() => labelInfo.Text = "Sipariş çekme işlemi başladı.");
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Text = "Sipariş Zamanlayıcısını Durdur");
                toolStripMenuItem_stopOrder.Text = "Sipariş Durdur";
            }
        }

        private void CheckBoxStopAll_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxStopAll.Checked) {
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Checked = true); ;
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Checked = true);
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Checked = true);

                checkBoxStopAll.Invoke(() => checkBoxStopAll.Text = "Tüm Zamanlayıcıları Başlat");
                toolStripMenuItem_stopAll.Text = "Hepsini Başlat";
            }
            else {
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Checked = false); ;
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Checked = false);
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Checked = false);

                checkBoxStopAll.Invoke(() => checkBoxStopAll.Text = "Tüm Zamanlayıcıları Durdur");
                toolStripMenuItem_stopAll.Text = "Hepsini Durdur";
            }
        }
        #endregion

        #region notifyContextMenu
        /// NotifyContextMenu
        private void setUpUseNotify() {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            //notifyIcon1.BalloonTipText = "This is A Sample Application";
            //notifyIcon1.BalloonTipTitle = "Your Application Name";
            //notifyIcon1.ShowBalloonTip(1);
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e) {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void ToolStripMenuItem_open_Click(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ToolStripMenuItem_stopAll_Click(object sender, EventArgs e) {
            if (checkBoxStopAll.Checked) {
                checkBoxStopAll.Invoke(() => checkBoxStopAll.Checked = false);
            }
            else {
                checkBoxStopAll.Invoke(() => checkBoxStopAll.Checked = true);
            }
        }

        private void ToolStripMenuItem_stopFiyatStok_Click(object sender, EventArgs e) {
            if (checkBoxStopFiyatStok.Checked) {
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Checked = false); ;
            }
            else {
                checkBoxStopFiyatStok.Invoke(() => checkBoxStopFiyatStok.Checked = true); ;
            }
        }

        private void ToolStripMenuItem_stopOzelKod_Click(object sender, EventArgs e) {
            if (checkBoxStopOzelKod.Checked) {
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Checked = false);
            }
            else {
                checkBoxStopOzelKod.Invoke(() => checkBoxStopOzelKod.Checked = true);
            }
        }

        private void ToolStripMenuItem_stopOrder_Click(object sender, EventArgs e) {
            if (checkBoxStopOrder.Checked) {
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Checked = false);
            }
            else {
                checkBoxStopOrder.Invoke(() => checkBoxStopOrder.Checked = true);
            }
        }
        #endregion

        #region dateTime
        /// DateTimePicker

        private void TextBoxInterval_FiyatStok_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void TextBoxInterval_OzelKod_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void TextBoxInterval_Order_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }
        /// dateTime intervals
        private void DateTimePicker_FiyatStokLeft_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_FiyatStokLeft.Value.TimeOfDay >= dateTimePicker_FiyatStokRight.Value.TimeOfDay) {
                dateTimePicker_FiyatStokLeft.Value = dateTimePicker_FiyatStokRight.Value - TimeSpan.FromHours(1);
            }
        }

        private void DateTimePicker_OzelKodLeft_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_OzelKodLeft.Value.TimeOfDay >= dateTimePicker_OzelKodRight.Value.TimeOfDay) {
                dateTimePicker_OzelKodLeft.Value = dateTimePicker_OzelKodRight.Value - TimeSpan.FromHours(1);
            }
        }

        private void DateTimePicker_OrderLeft_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_OrderLeft.Value.TimeOfDay >= dateTimePicker_OrderRight.Value.TimeOfDay) {
                dateTimePicker_OrderLeft.Value = dateTimePicker_OrderRight.Value - TimeSpan.FromHours(1);
            }
        }

        private void DateTimePicker_FiyatStokRight_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_FiyatStokLeft.Value.TimeOfDay >= dateTimePicker_FiyatStokRight.Value.TimeOfDay) {
                dateTimePicker_FiyatStokRight.Value = dateTimePicker_FiyatStokLeft.Value + TimeSpan.FromHours(1);
            }
        }

        private void DateTimePicker_OzelKodRight_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_OzelKodLeft.Value.TimeOfDay >= dateTimePicker_OzelKodRight.Value.TimeOfDay) {
                dateTimePicker_OzelKodRight.Value = dateTimePicker_OzelKodLeft.Value + TimeSpan.FromHours(1);
            }
        }

        private void DateTimePicker_OrderRight_ValueChanged(object sender, EventArgs e) {
            if (dateTimePicker_OrderLeft.Value.TimeOfDay >= dateTimePicker_OrderRight.Value.TimeOfDay) {
                dateTimePicker_OrderRight.Value = dateTimePicker_OrderLeft.Value + TimeSpan.FromHours(1);
            }
        }
        #endregion

        private void TabTheControl_Selecting(object sender, TabControlCancelEventArgs e) {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
            richTextBox1.Text = Log.readLog(filePath);

        }

        private void MetroButton1_Click(object sender, EventArgs e) {
            /// save setting
            saveSetting("fiyatStok", textBoxInterval_FiyatStok.Text);
            saveSetting("urun", textBoxInterval_OzelKod.Text);
            saveSetting("order", textBoxInterval_Order.Text);

            saveSetting("fiyatStok_sag", dateTimePicker_FiyatStokRight.Value.ToString());
            saveSetting("fiyatStok_sol", dateTimePicker_FiyatStokLeft.Value.ToString());

            saveSetting("urun_sag", dateTimePicker_OzelKodRight.Value.ToString());
            saveSetting("urun_sol", dateTimePicker_OzelKodLeft.Value.ToString());

            saveSetting("order_sag", dateTimePicker_OrderRight.Value.ToString());
            saveSetting("order_sol", dateTimePicker_OrderLeft.Value.ToString());

            Properties.Settings.Default.Save();
        }

        private void savePropertySettings(string propertyName) {
            System.Configuration.SettingsProperty property = new System.Configuration.SettingsProperty(propertyName);
            property.DefaultValue = "Default";
            property.IsReadOnly = false;
            property.PropertyType = typeof(string);
            //property.Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"];
            property.Attributes.Add(typeof(System.Configuration.UserScopedSettingAttribute), new System.Configuration.UserScopedSettingAttribute());
            Properties.Settings.Default.Properties.Add(property);

        }

        private void saveSetting(string setting_Name, string setting_Value) {
            string property_name = setting_Name;
            SettingsProperty prop = null;

            if (Properties.Settings.Default.Properties[property_name] != null) {
                prop = Properties.Settings.Default.Properties[property_name];
            }
            else {
                prop = new System.Configuration.SettingsProperty(property_name);
                prop.PropertyType = typeof(string);
                Properties.Settings.Default.Properties.Add(prop);
                Properties.Settings.Default.Save();
            }

            Properties.Settings.Default.Properties[property_name].DefaultValue = setting_Value;
            Properties.Settings.Default.Save();
        }

        private void textBoxOrder_DaysAgo_TextChanged(object sender, EventArgs e) {
            setUpTextBoxes();
        }

        private void metroButton_SaveChanges_Click(object sender, EventArgs e) {
            setUpTextBoxes();
        }

        private void metroButton5_Click(object sender, EventArgs e) {
            //RawPrinterHelper rawPrinterHelper = new RawPrinterHelper();
            //const string printerName = "RONGTA 80mm Series Printer";
            //string eCut = (char)27 + "i" + System.Environment.NewLine;
            //if (rawPrinterHelper.PrinterIsOpen == false) {
            //    rawPrinterHelper.OpenPrint(printerName);
            //    rawPrinterHelper.SendStringToPrinter(printerName, eCut);
            //    if (rawPrinterHelper.PrinterIsOpen == true) {
            //        rawPrinterHelper.ClosePrint();
            //    }
            //}

            RawPrint2.print();


        }
    }// form1 class
}// namespace
