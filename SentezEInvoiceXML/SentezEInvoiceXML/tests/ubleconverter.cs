
//using System;
//using Dycode.SimpleUBL.Common;
//using Dycode.SimpleUBL;

//class ExampleNET {
//    static void Main(string[] args) {
//        try {
//            Invoice i = new Invoice();
//            // Validate document by schema and then by value before loading
//            errors = i.GetValidationErrors("UBL-Invoice-2.0-Example.xml",
//                                           "OASIS/os-UBL-2.0/xsd/maindoc/UBL-Invoice-2.0.xsd",
//                                           "OASIS/os-UBL-2.0/val/defaultCodeList.xsl");
//            // if no validation errors found, document is valid
//            if (!String.IsNullOrEmpty(errors)) {
//                Console.Write("Validation error: " + errors);
//                return;
//            }
//            // load validated document
//            i.Read("UBL-Invoice-2.0-Example.xml");

//            // get some information from the document
//            Console.WriteLine("Invoice ID:\t\t\t\t" + i.ID.Value);
//            Console.WriteLine("Invoice IssueDate:\t\t\t" + i.IssueDate.Date);
//            Console.WriteLine("Invoice IssueTime:\t\t\t" + i.IssueTime.TimeOfDay);
//            Console.WriteLine("Invoice AccountingSupplierParty:\t" + i.AccountingSupplierParty.Party.PartyNames[0].Name.Value);
//            Console.WriteLine("Invoice AccountingCustomerParty:\t" + i.AccountingCustomerParty.Party.PartyNames[0].Name.Value);
//            Console.WriteLine("Invoice LegalMonetaryTotal:\t\t" + i.LegalMonetaryTotal.PayableAmount.Value);

//            // create new invoice line to add to the document
//            InvoiceLine il = new InvoiceLine();

//            // set invoice line information

//            // you can create "Identifier" object and add it to the invoice line "il.ID = new Identifier("IL")"
//            // or let it be done automatically like in our example
//            il.ID.Value = "IL";
//            il.InvoicedQuantity.UnitCode = "KGM";
//            il.InvoicedQuantity.Value = 90;
//            il.LineExtensionAmount.CurrencyID = "GEL";
//            il.LineExtensionAmount.Value = 90;
//            il.Price.PriceAmount.Value = 1;
//            il.Price.PriceAmount.CurrencyID = "USD";
//            il.Item.Descriptions.Add(new Dycode.SimpleUBL.Common.Text("Description goes here."));
//            il.Item.Name.Value = "Name goes here.";
//            il.Item.BuyersItemIdentification.ID.Value = "ID123";
//            il.Item.SellersItemIdentification.ID.Value = "ID987";

//            // add new invoice line to the document
//            i.InvoiceLines.Add(il);

//            // create XML from the Invoice document and save to the specified file
//            // you can get XML string by calling "i.getXML()" also
//            i.Write("ModifiedInvoiceNET.xml");
//        }
//        catch (Exception ex) {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}