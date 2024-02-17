using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;

namespace UGCore {
    public static class RawPrint2 {
        public static void print() {
            Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSock.NoDelay = true;
            IPAddress ip = IPAddress.Parse("192.168.1.86");
            IPEndPoint remoteEP = new IPEndPoint(ip, 9100);
            clientSock.Connect(remoteEP);
            Encoding enc = Encoding.ASCII;

            //// Line feed hexadecimal values
            //byte[] bEsc = new byte[4];
            //bEsc[0] = 0x0A;
            //bEsc[1] = 0x0A;
            //bEsc[2] = 0x0A;
            //bEsc[3] = 0x0A;

            //// Send the bytes over 
            //clientSock.Send(bEsc);

            //string GS = Convert.ToString((char)29);
            //string ESC = Convert.ToString((char)27);
            //string COMMAND = "";
            //COMMAND = ESC + "@";
            //COMMAND += GS + "V" + (char)48;
            //string output = ESC + "i" + (char)48;

            // Sends an ESC/POS command to the printer to cut the paper
            //string output = Convert.ToChar(29) + "V" + Convert.ToChar(65) + Convert.ToChar(0);
            //string output = Convert.ToChar(27) + Convert.ToChar(77) + Environment.NewLine;
            //string output = "ESC m";

            //string output = "" + Convert.ToChar(27) + Convert.ToChar(105);

            // Sends an ESC/POS command to the printer to cut the paper
            string output = "" + Convert.ToChar(27) + Convert.ToChar(105) + Convert.ToChar(0) + Convert.ToChar(27) + Convert.ToChar(109) + Convert.ToChar(0);
            Console.WriteLine(output); 
            char[] array = output.Trim().ToCharArray();
            byte[] byData = enc.GetBytes(array);
            clientSock.Send(byData);
            clientSock.Close();
        }
    }

    public class RawPrinterHelper {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, ref IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In()][MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, ref Int32 dwWritten);

        private IntPtr hPrinter = new IntPtr(0);
        private DOCINFOA di = new DOCINFOA();
        private bool PrinterOpen = false;

        public bool PrinterIsOpen {
            get {
                return PrinterOpen;
            }
        }

        public bool OpenPrint(string szPrinterName) {
            if (PrinterOpen == false) {
                di.pDocName = ".NET RAW Document";
                di.pDataType = "RAW";

                if (OpenPrinter(szPrinterName.Normalize(), ref hPrinter, IntPtr.Zero)) {
                    if (StartDocPrinter(hPrinter, 1, di)) {
                        if (StartPagePrinter(hPrinter))
                            PrinterOpen = true;
                    }
                }
            }

            return PrinterOpen;
        }

        public void ClosePrint() {
            if (PrinterOpen) {
                EndPagePrinter(hPrinter);
                EndDocPrinter(hPrinter);
                ClosePrinter(hPrinter);
                PrinterOpen = false;
            }
        }

        public bool SendStringToPrinter(string szPrinterName, string szString) {
            if (PrinterOpen) {
                IntPtr pBytes;
                Int32 dwCount;
                Int32 dwWritten = 0;

                dwCount = szString.Length;

                pBytes = Marshal.StringToCoTaskMemAnsi(szString);

                var res = WritePrinter(hPrinter, pBytes, dwCount, ref dwWritten);
                Marshal.FreeCoTaskMem(pBytes);
                return res;
            }
            else
                return false;
        }
    }
}