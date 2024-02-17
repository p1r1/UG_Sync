using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using UGCore;

namespace UGSyncUI {
    static class Program {
        private static string appGuid = "361A27FD-0449-494D-9009-3934F5A17DEA";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
#if DEBUG
            ConsoleHelper.Initialize();
            Console.WriteLine("Mode=Debug");
            appGuid = "C462EE59-F346-477F-AF53-4DEDC0725F74";
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-US");

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
                    Application.Run(new MainForm());

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