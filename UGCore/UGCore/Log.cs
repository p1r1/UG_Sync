using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace UGCore {
    public static class Log {
        private static readonly object _objectLock = new object();

        public static void append2(string logMessage, string filePath) {
            /// only one thread can own this lock, so other threads
            /// entering this method will wait here until lock is available.
            // lock (_objectLock) {
            // using (FileStream myFile = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write)) {

            System.Threading.Monitor.Enter(_objectLock);
            try {
                if (filePath.ToString() == string.Empty || filePath.ToString() == null) {
                    filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".uglog";
                }
                using (var w = File.Open(filePath, FileMode.Append | FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write)) {
                    System.Threading.Thread.Sleep(100);
                    byte[] bytes = new UTF8Encoding(true).GetBytes(string.Format("{0} {1}:\n{2}\n{3}", 
                                    DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), logMessage, "_________________________________________\n"));
                    w.Write(bytes, 0, bytes.Length);
                    w.Flush();
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex);
            }
            finally {
                System.Threading.Monitor.Exit(_objectLock);
                //Console.WriteLine("{0} releasing the LOG");
            }

            //}
        }

        static ReaderWriterLock locker = new ReaderWriterLock();
        public static void append(this string text, string filePath) {
            try {
                locker.AcquireWriterLock(int.MaxValue); //You might wanna change timeout value 
                System.IO.File.AppendAllLines(filePath, new[] { text });
                //Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", ""), "debug.txt")
            }
            catch {

            }
            finally {
                locker.ReleaseWriterLock();
            }
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
            //        filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".uglog";
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
            Console.WriteLine("deleteYesterdayLog");
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] files = di.GetFiles("*.log")
                                 .Where(p => p.Extension == ".log").ToArray();
            foreach (FileInfo file in files) {
                //Console.WriteLine(file.Name);
                try {
                    if (file.Name.Contains(DateTime.Now.ToString("dd-MM-yyyy")) ||
                        file.Name.Contains(DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")) ||
                        file.Name.Contains(DateTime.Now.AddDays(-2).ToString("dd-MM-yyyy"))) {
                        /// keep 3 day log
                        continue;
                    }
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch { }
            }

            //for (int i = 0; i < 24; i++) {
            //    StringBuilder sb = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            //    sb.Append("Info");
            //    sb.Append("_");
            //    DateTime yesterday = DateTime.Now.AddDays(-1);
            //    sb.Append(yesterday.ToString("dd-MM-yyyy"));
            //    sb.Append("_");
            //    sb.Append(i.ToString());
            //    sb.Append(".uglog");
            //    if (File.Exists(sb.ToString())) {
            //        //Console.WriteLine(sb.ToString());
            //        File.Delete(sb.ToString());
            //    }
            //    sb.Clear();
            //}

        }


    }


}
