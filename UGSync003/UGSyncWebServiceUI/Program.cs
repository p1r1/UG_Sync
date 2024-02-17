using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UGCore;

namespace UGSyncWebServiceUI {
    static class Program {
        private static string appGuid = "E4A815FB-B492-41A8-911C-5191B7C5E879";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-US");
#if DEBUG
            ConsoleHelper.Initialize();
            Console.WriteLine("Mode=Debug");
            appGuid = "{1BF7A840-D1AB-4AEB-94E5-066E4D2FB903}";
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /// run only one app
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid)) {
                if (!mutex.WaitOne(0, false)) {
                    MessageBox.Show("Instance already running");
                    return;
                }

                //clearLicenseAndKey();
                if (!License.isLicenseValid()) {
                    Application.EnableVisualStyles();
                    LicenseForm licenseForm = new LicenseForm();
                    Application.Run(licenseForm);
                    licenseForm.Close();
                    licenseForm.Dispose();
                }
                if (License.isLicenseValid()) {
                    if (IsAlreadyRunning()) {
                        Application.Exit();
                    }
                    Application.EnableVisualStyles();
                    Application.Run(new Form1());
                }
            }
            //void clearLicenseAndKey() {
            //    Properties.Settings.Default.publicKey = "";
            //    Properties.Settings.Default.license = "";
            //    Properties.Settings.Default.Save();
            //}
        }

        private static bool IsAlreadyRunning() {
            string strLoc = Assembly.GetExecutingAssembly().Location;
            FileSystemInfo fileInfo = new FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            bool bCreatedNew;

            Mutex mutex = new Mutex(true, "Global\\" + sExeName, out bCreatedNew);
            if (bCreatedNew)
                mutex.ReleaseMutex();

            return !bCreatedNew;
        }
    }
}
