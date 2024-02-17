using System;
using System.Windows.Forms;
using UGCore;

namespace UGSyncUI {
    public partial class LicenseForm : MetroFramework.Forms.MetroForm {

        License license;
        public LicenseForm() {
            InitializeComponent();
            license = new License();
        }

        private void MetroButton1_Click(object sender, EventArgs e) {

            ///get license
            const int LICENSE_DAY_LIMIT = 90;
            //"2100-01-01", CultureInfo.InvariantCulture
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime exprationDate = DateTime.Parse(now) + TimeSpan.FromDays(LICENSE_DAY_LIMIT);

            if (textBoxUserName.Text.Trim() == string.Empty ||
                textBoxCompanyName.Text.Trim() == string.Empty ||
                textBoxSerialKey.Text.Trim() == string.Empty) {
                MessageBox.Show("Textbox boş olamaz!");
                return;
            }

            if (/*license.validateSerial(textBoxSerialKey.Text) == false ||*/ license.validateAppCode(textBoxSerialKey.Text) == false) {
                textBoxSerialKey.Text = "";
                MessageBox.Show("Ürün anahtarı yanlış!");
                return;
            }

            string serialKey = textBoxSerialKey.Text.Trim();

            string userName = textBoxUserName.Text.Trim();
            string companyName = textBoxCompanyName.Text.Trim();
            Tuple<string, string> tupleKeyPair = License.generateKey();

            try {
                /// clear license
                Properties.Settings.Default.publicKey = "";
                Properties.Settings.Default.license = "";
                Properties.Settings.Default.Save();

                Properties.Settings.Default.publicKey = tupleKeyPair.Item1;
                Properties.Settings.Default.Save();

                license.initLicense(serialKey, userName, companyName, exprationDate, tupleKeyPair.Item1, tupleKeyPair.Item2);

                string licenseSerializedText = license.createSignedLicense();

                Properties.Settings.Default.license = licenseSerializedText;
                Properties.Settings.Default.Save();

            }
            catch (Exception) {
                MessageBox.Show("Lisans kaydolmadı!\nSağlayıcınıza başvurun.");
            }

            this.Hide();
            var mainform = new MainForm();
            mainform.Closed += (s, args) => this.Close();
            mainform.Show();
            //Serialize.SerializeObject<License>("license", license.createSignedLicense);
        }


    }
}