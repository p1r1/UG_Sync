using System;
using System.IO;
using System.Text;

namespace UGCore {
    public static class Log {
        private static readonly object _objectLock = new object();
        private static readonly object _objectLock2 = new object();

        public static void append(string logMessage, string filePath) {
            /// only one thread can own this lock, so other threads
            /// entering this method will wait here until lock is available.
            // lock (_objectLock) {
            // using (FileStream myFile = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write)) {

            System.Threading.Monitor.Enter(_objectLock);
            try {
                if (filePath.ToString() == string.Empty || filePath.ToString() == null) {
                    filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
                }
                using (var w = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)) {
                    byte[] bytes = new UTF8Encoding(true).GetBytes(string.Format("{0} {1}:\n{2}\n{3}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), logMessage, "_________________________________________\n"));
                    w.Write(bytes, 0, bytes.Length);
                    w.Flush();
                }
            }
            catch {
                //Console.WriteLine(logMessage);
            }
            finally {
                System.Threading.Monitor.Exit(_objectLock);
                //Console.WriteLine("{0} releasing the LOG");
            }

            //}
        }

        public static string readLog(string filePath) {
            //// only one thread can own this lock, so other threads
            //// entering this method will wait here until lock is
            //// available.
            ////lock (_objectLock) {
            ////using (FileStream myFile = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write)) {

            //System.Threading.Monitor.Enter(_objectLock2);
            //try {
            //    if (filePath.ToString() == string.Empty || filePath.ToString() == null) {
            //        filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
            //    }
            //    if (!File.Exists(filePath)) {
            //        File.Create(filePath);
            //    }

            //    Char[] buffer;

            //    using (var sr = new StreamReader(filePath)) {
            //        buffer = new Char[(int)sr.BaseStream.Length];

            //        sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            //    }

            //    return new String(buffer);

            //}
            //catch {
            //    //Console.WriteLine(logMessage);
            //}
            //finally {
            //    System.Threading.Monitor.Exit(_objectLock2);
            //    //Console.WriteLine("{0} releasing the LOG");
            //}
            return "";
            ////}
        }

        public static void deleteYesterdayLog() {
            for (int i = 0; i < 24; i++) {
                StringBuilder sb = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
                sb.Append("Info");
                sb.Append("_");
                DateTime yesterday = DateTime.Now.AddDays(-1);
                sb.Append(yesterday.ToString("dd-MM-yyyy"));
                sb.Append("_");
                sb.Append(i.ToString());
                sb.Append(".log");
                if (File.Exists(sb.ToString())) {
                    //Console.WriteLine(sb.ToString());
                    File.Delete(sb.ToString());
                }
                sb.Clear();
            }

        }


    }


}
