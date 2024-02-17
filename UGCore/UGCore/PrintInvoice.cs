using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace UGCore {
    public static class PrintInvoice {
        public static bool PrintPDF(string html, string printer, int copies = 1) {
            try {
                var config = new PdfGenerateConfig();
                config.PageOrientation = PageOrientation.Portrait;
                config.PageSize = PageSize.A4;
                config.SetMargins(0);


                /// add page to pdf doc
                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                PdfPage page = new PdfPage();
                page.Orientation = PageOrientation.Portrait;
                pdf = PdfGenerator.GeneratePdf(html, PageSize.A2);/// impoertant one is this
                //pdf2.Save(@"d:/yow23.pdf");

                MemoryStream ms = new MemoryStream();
                pdf.Save(ms);
                //return ms;

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

                // get a4 paper size
                IEnumerable<PaperSize> paperSizes = printerSettings.PaperSizes.Cast<PaperSize>();
                PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4); 

                // Now print the PDF document
                using (var document = PdfiumViewer.PdfDocument.Load(ms)) {
                    // Create our page settings for the paper size selected
                    //Console.WriteLine(realHeight);
                    var pageSettings = new PageSettings(printerSettings) {
                        Margins = new Margins(0, 0, 0, 0),
                        //PaperSize = new PaperSize("CustomOFM", PAPER_WIDTH, (int)(document.PageSizes[0].Height * 0.75 + 1)
                        PaperSize = sizeA4,
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
                ms.Dispose();
                return true;
            }
            catch (System.Exception e) {
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + e);
                return false;
            }
        }

    }
}
