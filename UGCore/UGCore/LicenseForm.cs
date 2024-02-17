using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UGCore {
    public partial class LicenseForm : Form {
        public readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + "FrameworkMetro";
        private License license;
        public LicenseForm() {
            InitializeComponent();
            license = new License();
        }

        private void Button1_Click(object sender, EventArgs e) {
            /// ///
            /// Write setting to xml
            /// ///
            ///get license
            const int LICENSE_DAY_LIMIT = 90;
            //"2100-01-01", CultureInfo.InvariantCulture
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime exprationDate = DateTime.Parse(now) + TimeSpan.FromDays(LICENSE_DAY_LIMIT);

            ///if boxes empty then return
            if (textBoxUserName.Text.Trim() == string.Empty ||
                textBoxCompanyName.Text.Trim() == string.Empty ||
                textBoxSerialKey.Text.Trim() == string.Empty) {
                MessageBox.Show("Textbox boş olamaz!");
                return;
            }
            /// validate licence
            if (/*license.validateSerial(textBoxSerialKey.Text) == false ||*/ license.validateAppCode(textBoxSerialKey.Text) == false) {
                textBoxSerialKey.Text = "";
                MessageBox.Show("Ürün anahtarı yanlış!");
                return;
            }

            string serialKey = textBoxSerialKey.Text.Trim();
            string userName = textBoxUserName.Text.Trim();
            string companyName = textBoxCompanyName.Text.Trim();
            Tuple<string, string> tupleKeyPair = License.generateKey();

            //TODO: check serial digit by digit
            //TODO: check serial digit by digit DONE!!!
            if (!isParsedSerialValid(serialKey)) {
                MessageBox.Show("Ürün anahtarı yanlış!");
                return;
            }

            try {
                /// clear license
                if (File.Exists(filePath)) {
                    try {
                        File.Delete(filePath);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }

                string publicKey = tupleKeyPair.Item1;
                license.initLicense(serialKey, userName, companyName, exprationDate, tupleKeyPair.Item1, tupleKeyPair.Item2);
                string licenseSerializedText = license.createSignedLicense();

                var userRecord = new UserRecord {
                    user = System.Security.Principal.WindowsIdentity.GetCurrent().Name, // "UserName1",
                    serialRecord = new SerialRecord { publicKey = publicKey, serial = licenseSerializedText }                    
                };
                XmlHelper.ToXmlFile(userRecord, filePath);

            }
            catch (Exception) {
                MessageBox.Show("Lisans kaydolmadı!\nSağlayıcınıza başvurun.");
            }

            this.Close();

            // TODO: make new form
            // TODO: make new form DONE!
            //this.Hide();
            //var mainform = new FormBot();
            //mainform.Closed += (s, args) => this.Close();
            //mainform.Show();
            //Serialize.SerializeObject<License>("license", license.createSignedLicense);
        }

        private bool isParsedSerialValid(string serialKey) {
            bool result = false;
            if (!string.IsNullOrEmpty(serialKey)) {
                try {
                    string[] serialKeyList = serialKey.Split('-');
                    for (int i = 1; i < serialKeyList.Length -1; i++) {
                        //Console.WriteLine(serialKeyList[i].ToString());
                        char[] charArray = serialKeyList[i].ToString().ToCharArray();
                        int asciiNumber = (int)charArray[0];
                        string asciiString = charArray[1].ToString() + charArray[2].ToString() + charArray[3].ToString();
                        //Console.WriteLine("asciiString->" + asciiString);
                        //Console.WriteLine("asciiNumber->" + asciiNumber.ToString("000"));
                        if (asciiString == asciiNumber.ToString("000")) {
                            result =  true;
                        }
                        else {
                            return false;
                        }
                    }
                }
                catch (Exception) { }
            }
            return result;
        }



    }
}