using System;
using System.ServiceModel;
using System.Windows.Forms;
using UGSyncWebService;

namespace UGSyncWebServiceUI {
    public partial class Form1 : Form {

        private ServiceHost host;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            setUpUseNotify();
            notifyIcon1.Visible = false;
            ///stop at closing

            ///init wcf
            initWCFWebService();

        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            notifyIcon1.Visible = false;
            if (host.State == CommunicationState.Opened) {
                /// stop WCF host
                host.Close();
            }

            Application.Exit();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Application.MessageLoop) {
                // WinForms app
                Application.Exit();
                try {
                    Environment.Exit(1);
                }
                catch (Exception) {
                }
            }
            else {
                // Console app
                Environment.Exit(1);
            }
            if (host.State == CommunicationState.Opened) {
                /// stop WCF host
                host.Close();
            }
        }

        private void initWCFWebService() {
            /// ///
            /// WCF host
            /// ///
            host = new ServiceHost(typeof(UGSyncWCF));
            host.Open();
            //#if DEBUG
            //#else
            //            host.Open();
            //#endif
        }

        private void setUpUseNotify() {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

    }
}
