using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using PdfSharp;
using PdfSharp.Pdf;
using RazorEngine;
using RazorEngine.Templating;
using System.Data;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp.Drawing;
//using TheArtOfDev.HtmlRenderer.Adapters.Entities;
//using TheArtOfDev.HtmlRenderer.Core;
//using TheArtOfDev.HtmlRenderer.Core.Entities;
//using TheArtOfDev.HtmlRenderer.Core.Utils;
//using TheArtOfDev.HtmlRenderer.PdfSharp.Adapters;
//using TheArtOfDev.HtmlRenderer.PdfSharp.Utilities;

namespace UGCore {
    public class PrintableReceiptItem {
        public string Barcode { get; set; }
        public string Name {get; set;}
        public string Quantity { get; set; }
        public string Box { get; set; }
        public double Price { get; set; }
        
    }

    public class PrintableReceipt {
        /// cargo always uppercase
        public string CargoName { get; set; }
        public string SpecialCode { get; set; }
        public string SpecialCodeBarcode { get; set; }
        public string CargoBarcode { get; set; }
        //public string CargoBarcodeQR { get; set; }//
        public string CargoBarcodeString { get; set; }
        public string CargoNote { get; set; }
        public string PaymentPlan { get; set; }
        public string ShippingName { get; set; }
        public string BillingName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCityAndTown { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingEmail { get; set; }
        public string ShippingNote { get; set; }
        public string Ship68 { get; set; }
        public string PayGrandTotal { get; set; }


        public string ReceiptDocNo { get; set; }
        //public string InsertHour { get; set; }//
        //public string InsertDate { get; set; }//
        //public string ShippingDate { get; set; }//
        //public string TaxNo { get; set; }//
        //public string TaxOffice { get; set; }//
        //public string ReceiptNoQR { get; set; }//
        public string ReceiptNoBarcode { get; set; }
        public List<PrintableReceiptItem> itemList{ get; set;}
        public string SetBarcodes { get; set; }
        public string RepeatedProduct { get; set; }

        public string generateBarcode(string value, int width = 280, int height = 50) {
            //zxi
            try {
                //var content = "123456789012345678";
                var writer = new BarcodeWriter {
                    Format = BarcodeFormat.CODE_128,
                    Options = new ZXing.Common.EncodingOptions {
                        Width = width,
                        Height = height,
                        Margin = 1,
                        PureBarcode = true
                    }
                };
                return !string.IsNullOrEmpty(value) ? BitmapToBase64(writer.Write(value)) : "";
            }
            catch (Exception) {
                return "";
            }

        }
        
        public string generateQRBarcode(Bitmap  logo, string text, int width=500, int height=500) {
            try {
                var bw = new ZXing.BarcodeWriter();

                var encOptions = new ZXing.Common.EncodingOptions {
                    Width = width,
                    Height = height,
                    Margin = 0,
                    PureBarcode = false
                };

                encOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

                bw.Renderer = new BitmapRenderer();
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                Bitmap bm = bw.Write(text);
                Bitmap overlay = ScaleImage(logo, bm.Width / 2, bm.Height / 2);

                int deltaHeigth = bm.Height - overlay.Height;
                int deltaWidth = bm.Width - overlay.Width;

                Graphics g = Graphics.FromImage(bm);
                g.DrawImage(overlay, new Point(deltaWidth / 2, deltaHeigth / 2));

                return BitmapToBase64(bm);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return "";
            }
            
        }

        public Bitmap ScaleImage(Bitmap image, int maxWidth, int maxHeight) {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(maxWidth, maxHeight);
            using (var graphics = Graphics.FromImage(newImage)) {
                // Calculate x and y which center the image
                int y = (maxHeight / 2) - newHeight / 2;
                int x = (maxWidth / 2) - newWidth / 2;

                // Draw image on x and y with newWidth and newHeight
                graphics.DrawImage(image, x, y, newWidth, newHeight);
            }

            return newImage;
        }

        public static string BitmapToBase64(Bitmap bImage) {
            // Your Bitmap Image
            System.IO.MemoryStream ms = new MemoryStream();
            bImage.Save(ms, ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            var SigBase64 = Convert.ToBase64String(byteImage); // Get Base64

            return "data:image/jpeg;base64," + SigBase64;
        }
        //public bool checkQR(Bitmap QrCode) {
        //    var reader = new BarcodeReader();
        //    var result = reader.Decode(QrCode);
        //    if (result == null)
        //        return false;
        //    return result.Text == url;
        //}

    }

    public static class PrintObj {
        /// <summary>
        /// nuget packages:
        /// PdfiumViewer
        /// PdfiumViewer.Native.x86.v8 - xfa
        /// PDFSharp beta version install with nuget console
        /// Install-Package HtmlRenderer.PdfSharp -Version 1.5.1-beta1
        /// TheArtOfDev.HtmlRenderer.PdfSharp;
        /// Install-Package RazorEngine
        /// zxing barcode
        /// </summary>
        private const int PAPER_WIDTH = 290;
        private const int WIDTH = 350;
        private const int HEIHGT = 1;
        private const int LINE_HEIHGT = 10;
        //private static string finalHtml;
        //private static MemoryStream stream;
        public static int realHeight { get; set; }

        public static string FillFinalHtml(string razorHtmlTemplate, PrintableReceipt pr, string key) {
            try {                
                //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                //string razorHtmlTemplate = File.ReadAllText(projectDirectory + "/Resources/RazorHtmlTemplate.html", System.Text.Encoding.Default);
                return Engine.Razor.RunCompile(razorHtmlTemplate, key, typeof(PrintableReceipt), pr);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static MemoryStream CreatePDFFromHTML(string finalHtml) {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("en-US");
            try {
                /// add lines to height
                ///// get html file as text
                //string html = File.ReadAllText(filePath);
                
                /// created pdf config
                var config = new PdfGenerateConfig();
                config.PageOrientation = PageOrientation.Portrait;
                config.ManualPageSize = new PdfSharp.Drawing.XSize(WIDTH, HEIHGT);
                config.SetMargins(0);

                /// add page to pdf doc
                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                PdfPage page = new PdfPage();
                pdf.PageLayout = PdfPageLayout.SinglePage;
                page.Orientation = PageOrientation.Portrait;
                Console.WriteLine();
                pdf = PdfGenerator.GeneratePdf(finalHtml, config);
                Console.WriteLine();
                //pdf.Save(@"d:/yow2.pdf");
                pdf.AddPage();

                realHeight = 0;
                for (int i = 0; i < pdf.Pages.Count; i++) {
                    //if (HasContent(pdf.Pages[i]))
                        realHeight += (int)(pdf.Pages[i].Height.Value + 1);
                }

                ///recreate with decent height
                /// created pdf config
                var config2 = new PdfGenerateConfig();
                config2.PageOrientation = PageOrientation.Portrait;
                config2.ManualPageSize = new PdfSharp.Drawing.XSize(WIDTH, realHeight);
                config2.SetMargins(0);

                /// add page to pdf doc
                PdfSharp.Pdf.PdfDocument pdf2 = new PdfSharp.Pdf.PdfDocument();
                PdfPage page2 = new PdfPage();
                //pdf2.PageLayout = PdfPageLayout.SinglePage;
                page2.Orientation = PageOrientation.Portrait;
                pdf2 = PdfGenerator.GeneratePdf(finalHtml, config2);
                pdf2.AddPage();

                
                /// create pdf from stream and create last pdfstream
                MemoryStream stream2 = null;
                using (MemoryStream stream = new MemoryStream()) {
                    pdf2.Save(stream);
                    //pdf2.Save(@"d:/yow.pdf");
                    stream2 = new MemoryStream(stream.ToArray());
                }

                ///// save as pdf
                //string path = $"D:/fis{new Random().Next(25200).ToString()}.pdf";
                //pdf.Save(path);

                return stream2;
            }
            catch (Exception ex) {
                Console.WriteLine("***CreatePDFFromHTML***" + ex);
                return null;
                //throw;
            }
        }


        public static bool PrintPDF(string printer, string paperName, int lineCount, MemoryStream stream, int copies = 1) {
            try {
                // Create the printer settings for our printer
                var printerSettings = new PrinterSettings {
                    PrinterName = printer,
                    Copies = (short)copies,
                    PrintFileName = "OFMdoc"
                };

                // Add list of installed printers found to the combo box.
                // The pkInstalledPrinters string will be used to provide the display string.
                //String pkInstalledPrinters;
                //for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++) {
                //    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                //    Console.WriteLine(pkInstalledPrinters);
                //}

                // Now print the PDF document
                using (var document = PdfiumViewer.PdfDocument.Load(stream)) {
                    // Create our page settings for the paper size selected
                    //Console.WriteLine(realHeight);
                    var pageSettings = new PageSettings(printerSettings) {
                        Margins = new Margins(0, 0, 0, 0),
                        PaperSize = new PaperSize("CustomOFM", PAPER_WIDTH, (int)(document.PageSizes[0].Height * 0.75 + 1)
                        /*(int)(((document.PageSizes[0].Height + 1) - 350 + (lineCount * LINE_HEIHGT))*0.86)*/),/*(int)(realHeight-900)*/
                        Landscape = false
                    };
                    
                    using (var printDocument = document.CreatePrintDocument(PdfiumViewer.PdfPrintMode.CutMargin)) {
                        //printDocument.OriginAtMargins = true;
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                        //document.Save("D:/yow3.pdf" );
                    }
                }
                return true;
            }
            catch (System.Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        
        //public static bool PrintGivenPdf(string ReceiptIdentifier,  bool isThisReceiptSpecialCode = false) {
        //    bool result = false;
        //    try {
        //        string type_1_3 = "3";
        //        //Console.WriteLine(type_1_3);
        //        string receiptRecId = string.Empty;
        //        SqlObj sql = new SqlObj(SqlObj.DEFAULT_CONN_STRING);
        //        /// if this is receipt special code then get recid
        //        if (isThisReceiptSpecialCode) {
        //            sql.selectString($@"SELECT RecId FROM Erp_InventoryReceipt WHERE SpecialCode='{ReceiptIdentifier}'", true);
        //            receiptRecId = sql.scalarStringGet;
        //        }
        //        else {
        //            receiptRecId = ReceiptIdentifier;
        //        }

        //        string querry = "";
        //        string updateType = "";
        //        if (type_1_3 == "1") {
        //            // ust nusha big
        //            querry = $@"SELECT Attachment FROM Erp_InventoryReceiptAttachment WHERE Type='1' AND InventoryReceiptId='{receiptRecId}' ORDER BY RecId DESC";
        //            updateType = "1,4";
        //        }
        //        else if (type_1_3 == "3") {
        //            // products alt ufak
        //            querry = $@"SELECT Attachment FROM Erp_InventoryReceiptAttachment WHERE Type='3' AND InventoryReceiptId='{receiptRecId}' ORDER BY RecId DESC";
        //            updateType = "3,5";
        //        }
        //        else {
        //            Console.WriteLine("type_1_3 is wrong");
        //            return false;
        //        }    
            
        //        sql.selectTable(querry, true);
        //        DataTable dat = sql.dataTableGet;
        //        MemoryStream ms = new MemoryStream((byte[])dat.Rows[0][0]);
        //        PrintObj.PrintPDF("RONGTA 80mm Series Printer", "", 1, ms);

        //        string updatePrint = $@"UPDATE Erp_InventoryReceiptAttachment SET Explanation = CONCAT(Explanation, ',1') WHERE Type IN ({updateType}) AND InventoryReceiptId = '{receiptRecId}'";
        //        Functions.sendSQLCommand(SqlObj.DEFAULT_CONN_STRING, updatePrint);
        //        result = true;
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return result;
        //}
                
        public static bool PrintGivenPdf(string ReceiptIdentifier,  bool isThisReceiptSpecialCode = false, bool isBigReceipt = false) {
            bool result = false;
            try {
                string receiptRecId = string.Empty;
                SqlObj sql = new SqlObj(Functions.GetConnString("ms_sql"));
                /// if this is receipt special code then get recid
                if (isThisReceiptSpecialCode) {
                    sql.selectString($@"SELECT RecId FROM Erp_InventoryReceipt WHERE SpecialCode='{ReceiptIdentifier}'", true);
                    receiptRecId = sql.scalarStringGet;
                }
                else {
                    sql.selectString($@"SELECT RecId FROM Erp_InventoryReceipt WHERE OrderIdFromWeb='{ReceiptIdentifier}'", true);
                    receiptRecId = sql.scalarStringGet;
                }

                if (isBigReceipt) {
                    /// Print ust nusha big
                    string querry = $@"SELECT Attachment FROM Erp_InventoryReceiptAttachment WHERE Type='1' AND InventoryReceiptId='{receiptRecId}' ORDER BY RecId DESC";
                    sql.selectTable(querry, true);
                    DataTable dat = sql.dataTableGet;
                    MemoryStream ms = new MemoryStream((byte[])dat.Rows[0][0]);
                    PrintObj.PrintPDF("RONGTA 80mm Series Printer", "", 1, ms);

                    string updatePrint = $@"UPDATE Erp_InventoryReceiptAttachment SET Explanation = CONCAT(Explanation, ',1') 
                                        WHERE Type IN ('1','4') AND InventoryReceiptId = '{receiptRecId}'";
                    sql.update(updatePrint, true);
                    result = true;
                }
                else {
                    /// Print products alt ufak
                    string querry = $@"SELECT Attachment FROM Erp_InventoryReceiptAttachment WHERE Type='3' AND InventoryReceiptId='{receiptRecId}' ORDER BY RecId DESC";                   
                    sql.selectTable(querry, true);
                    DataTable dat = sql.dataTableGet;
                    MemoryStream ms = new MemoryStream((byte[])dat.Rows[0][0]);
                    PrintObj.PrintPDF("RONGTA 80mm Series Printer", "", 1, ms);

                    string updatePrint = $@"UPDATE Erp_InventoryReceiptAttachment SET Explanation = CONCAT(Explanation, ',1') 
                                        WHERE Type IN ('3','5') AND InventoryReceiptId = '{receiptRecId}'";
                    sql.update(updatePrint, true);
                    result = true;
                }
                   
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public static void CleanRazorTemp() {
            try {
                var dir = new DirectoryInfo("c:\\temp");
                foreach (var file in Directory.GetFiles(dir.ToString())) {
                if (file.Contains("RazorEngine")) {
                        File.Delete(file);
                    }
                }
            }
            catch {
            }
           
        }


    }
}
