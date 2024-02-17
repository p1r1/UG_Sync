using System;
using System.Windows.Forms;
using UGCore;
/*
namespace UGSyncUI {
    public static class UGSyncLicense {
        public static bool isLicenseValid() {
            string licenseSeriazlizedText = Properties.Settings.Default.license;
            string publicKey = Properties.Settings.Default.publicKey;

            /// if serialKey or publicKey is empty
            if (licenseSeriazlizedText == string.Empty || publicKey == string.Empty) {
                MessageBox.Show("Ürün anahtarı girilmemiş!");
                return false;
            }

            /// validate here
            License license = new License();
            //labelInfo.Text = (license.exprationDateGet());
            Tuple<bool, string> verifyLicense = license.verifyLicense(publicKey, licenseSeriazlizedText);
            bool isExpired = verifyLicense.Item1;
            string verifyLicenseText = verifyLicense.Item2;

            ///  expired
            if (isExpired == false) {
                Properties.Settings.Default.publicKey = "";
                Properties.Settings.Default.license = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("Ürün anahtarının süresi dolmuş!");
                return false;
            }

            /// serialKey wrong
            if (verifyLicenseText != licenseSeriazlizedText && isExpired == false) {
                Properties.Settings.Default.publicKey = "";
                Properties.Settings.Default.license = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("Ürün anahtarının doğrulanamadı!");
                return false;
            }
            return true;
        }
    }

}
*/