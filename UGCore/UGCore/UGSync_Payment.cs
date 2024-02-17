using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace UGCore {
    public static class UGSync_Payment {

        public async static Task<bool> CheckReceiptsAndProcess(string inventoryReceiptRecId) {
            bool result = false;
            try {
                DataTable inventoryReceipt = Functions.getDataFromSql(Functions.GetConnString("ms_sql"),
                                                                      $@"SELECT Top 1 SpecialCode, PaymentPlanId, ReceiptDate, CurrentAccountId, InvoiceId, TransporterId
                                                                        FROM Erp_InventoryReceipt
                                                                        WHERE RecId = '{inventoryReceiptRecId}' 
                                                                              AND (IsTransportReceipt != 1 OR IsTransportReceipt IS NULL) 
                                                                              AND InvoiceId IS NOT NULL");
                DataTable invoiceReceipt = Functions.getDataFromSql(Functions.GetConnString("ms_sql"),
                                                                    $@"SELECT DocumentNo, GrandTotal
                                                                        FROM Erp_Invoice
                                                                        WHERE RecId='{inventoryReceipt.Rows[0]["InvoiceId"].ToString()}'");
                string paymentPlanId = inventoryReceipt.Rows[0]["PaymentPlanId"].ToString();
                string specialCode = inventoryReceipt.Rows[0]["SpecialCode"].ToString();
                if (string.IsNullOrEmpty(specialCode)) {
                    Console.WriteLine("InventoryReceipt specialCode is empty");
                    result = false;
                    return result;
                }
                string documentNo = invoiceReceipt.Rows[0]["DocumentNo"].ToString();
                string debit = invoiceReceipt.Rows[0]["GrandTotal"].ToString();
                if (string.IsNullOrEmpty(documentNo)) {
                    Console.WriteLine("Invoice documentNo specialCode is empty");
                    result = false;
                    return result;
                }
                List<Functions.SqlObj> SqlObjInventoryReceiptUpdate = new List<Functions.SqlObj> {
                    new Functions.SqlObj("IsTransportReceipt", "1"), // Erp_Currentaccountreceipt recid
                    new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new Functions.SqlObj("UpdatedBy", "24")
                };

                /// transport for kapıda ödeme
                string tranportId = inventoryReceipt.Rows[0]["TransporterId"].ToString();
                

                ///cct3d cct ccp3d
                if (paymentPlanId == "3" || paymentPlanId == "6" || paymentPlanId == "4" || paymentPlanId == "2") {//KK - KKtipi
                    await ProcessKK(Functions.GetConnString("ms_sql"),
                                     inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                     debit,
                                     inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                     documentNo, "3");// 3 - paratika nestpay
                    /// Enter only once 
                    Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());
                    result = true;
                }
                else if (paymentPlanId == "10002") { // pazara yeri - KKtipi
                    if (specialCode.Contains("UG-N")) { // N11
                        await ProcessKK(Functions.GetConnString("ms_sql"),
                                         inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                         debit,
                                         inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                         documentNo, "5");//5- doğuş planet
                        /// Enter only once 
                        Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());
                        result = true;
                    }
                }
                else if (paymentPlanId == "1") { // EFT - havaleEFTtipi
                    await ProcessEft(Functions.GetConnString("ms_sql"),
                                     inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                     debit,
                                     inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                     documentNo, "1"); // 1- albaraka
                    /// Enter only once 
                    Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());
                    result = true;

                }
                else if (paymentPlanId == "5" || paymentPlanId == "7") { // kapıda ödeme - havaleEFTtipi
                    if (tranportId == "3" ) { // yurtiçi
                        await ProcessEft(Functions.GetConnString("ms_sql"),
                                     inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                     debit,
                                     inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                     documentNo, "6");
                    }
                    else if (tranportId == "1") {//ptt
                        await ProcessEft(Functions.GetConnString("ms_sql"),
                                    inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                    debit,
                                    inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                    documentNo, "4");
                    }
                    else {
                        Console.WriteLine("diffrent transport id -> ptt");
                        await ProcessEft(Functions.GetConnString("ms_sql"),
                                                       inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                                                       debit,
                                                       inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                                                       documentNo, "4");
                    }                   
                    /// Enter only once 
                    Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());
                    result = true;
                }
                else {
                    Console.WriteLine("Other type of payment! = EFT");
                }

                /////////////////////////// old
                //if (inventoryReceipt.Rows[0]["PaymentPlanId"].ToString() == "1" ||
                //    inventoryReceipt.Rows[0]["PaymentPlanId"].ToString() == "5" ||
                //    inventoryReceipt.Rows[0]["PaymentPlanId"].ToString() == "7") { //EFT
                //    await ProcessEft(Functions.GetConnString("ms_sql"),
                //                     inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                //                     debit,
                //                     inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                //                     documentNo);
                //    /// Enter only once 
                    
                //    Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());
                //    result = true;
                //}
                //else {//KK
                //    await ProcessKK(Functions.GetConnString("ms_sql"),
                //                     inventoryReceipt.Rows[0]["ReceiptDate"].ToString(),
                //                     debit,
                //                     inventoryReceipt.Rows[0]["CurrentAccountId"].ToString(),
                //                     documentNo);
                //    /// Enter only once 
                //    Functions.updateSQL(Functions.GetConnString("ms_sql"), "Erp_InventoryReceipt", $@"RecId='{inventoryReceiptRecId}'", SqlObjInventoryReceiptUpdate.ToArray());

                //    result = true;
                //}

                return result;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return result;
            }
        }

        private async static Task<bool> ProcessKK(string connString, string receiptDate, string debit, string currentAccountId, string documentNo, string bankAccountId="3") {
            bool result = false; 
            try {
                //bool isTodaysReceiptExist = false;
                Tuple<string, string> tupleRecIds =  FindLastReceipt(connString);
                string lastCurrentAccountReceiptId = tupleRecIds.Item1;
                string lastBankReceiptId = tupleRecIds.Item2;
                if (string.IsNullOrEmpty(lastCurrentAccountReceiptId) || string.IsNullOrEmpty(lastBankReceiptId)) {
                    /// ///
                    /// create bank receipt 
                    /// don't forget to update sourceid
                    /// ///
                    string bankReceiptNo = Functions.executeScalar(connString, @"SELECT Top 1 ReceiptNo + 1 FROM Erp_BankReceipt
                                                                                WHERE ReceiptType=1 ORDER BY RecId DESC;");
                    bankReceiptNo = AddLeadingZerosToString(bankReceiptNo, 8);
                    List<Functions.SqlObj> SqlObjBankReceipt = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("WorkplaceId", " 2"),
                        new Functions.SqlObj("ReceiptType", " 1"),
                        new Functions.SqlObj("ReceiptNo", bankReceiptNo),
                        new Functions.SqlObj("ReceiptDate", receiptDate), // TODO: ask muhasebe and decide
                        new Functions.SqlObj("DocumentNo", ""),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),// payment price ?
                        new Functions.SqlObj("Credit", "0"),// always 0
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("ForexCredit", "0"),
                        new Functions.SqlObj("SourceModule", "3"), //3-finans
                        /*new Functions.SqlObj("SourceId", " 203263"),*/ // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("IsApproved", " 1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", " 0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceipt", SqlObjBankReceipt.ToArray());
                    string bankReceiptRecId = Functions.executeScalar(connString, @"SELECT Top 1 RecId FROM Erp_BankReceipt
                                                                                    WHERE ReceiptType=1 ORDER BY RecId DESC");

                    /// ///
                    /// bankrecipt item
                    /// ///
                    string bankReceiptItemOrderNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_BankReceiptItem 
                                                                                            WHERE BankReceiptId={bankReceiptRecId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(bankReceiptItemOrderNo)) {
                        bankReceiptItemOrderNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjBankReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("BankReceiptId", bankReceiptRecId),
                        new Functions.SqlObj("ReceiptType", "1"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("ReceiptSubType", "9"),
                        new Functions.SqlObj("BankAccountId", bankAccountId), //3-> netspay, 1-> albaraka
                        new Functions.SqlObj("ItemOrderNo", bankReceiptItemOrderNo),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),
                        new Functions.SqlObj("Explanation", documentNo),
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("Status", "1"),
                        new Functions.SqlObj("TransactionType", "5"),
                        new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceiptItem", SqlObjBankReceiptItem.ToArray());

                    ///// update  total debit downright
                    //double lastDebit;
                    //double debitDouble;
                    //string lastDebitString = Functions.executeScalar(connString, $"SELECT Debit FROM Erp_BankReceipt WHERE RecId='{lastBankReceiptId}'");
                    //double.TryParse(lastDebitString, out lastDebit);
                    //double.TryParse(debit, out debitDouble);

                    //if (lastDebit != 0) {
                    //    lastDebit += debitDouble;
                    //    Functions.updateSQL(connString, "Erp_BankReceipt", $"RecId='{lastBankReceiptId}'",
                    //                                     new Functions.SqlObj[] { new Functions.SqlObj("Debit", lastDebit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}

                    /// ///
                    /// currentaccountReceipt
                    /// ///
                    string currentAccountReceiptNo = Functions.executeScalar(connString, @"SELECT Top 1 ReceiptNo + 1 FROM Erp_CurrentAccountReceipt 
                                                                                             WHERE ReceiptType=50 ORDER BY RecId DESC;");
                    currentAccountReceiptNo = AddLeadingZerosToString(currentAccountReceiptNo, 8);
                    List<Functions.SqlObj> SqlObjCurrentAccountReceipt = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("ReceiptType", "50"),
                        new Functions.SqlObj("ReceiptNo", currentAccountReceiptNo),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("DocumentNo", ""),
                        new Functions.SqlObj("Debit", "0"),
                        new Functions.SqlObj("Credit", debit),
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("ForexCredit", "0"),
                        new Functions.SqlObj("BankReceiptId", bankReceiptRecId),
                        new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceipt", SqlObjCurrentAccountReceipt.ToArray());
                    string currentAccountReceiptRecId = Functions.executeScalar(connString, $@"SELECT Top 1 RecId FROM Erp_CurrentAccountReceipt
                                                                                                WHERE ReceiptType=50 ORDER BY RecId DESC;");
                    /// /// ///
                    /// currentaccountReceipt Item
                    /// ///
                    string currentAccountReceiptItemNo = Functions.executeScalar(connString, @"SELECT Top 1 ItemOrderNo + 1 FROM Erp_CurrentAccountReceiptItem 
                                                                                                WHERE ReceiptType=50 ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(currentAccountReceiptItemNo)) {
                        currentAccountReceiptItemNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItem = new List<Functions.SqlObj> {
                         new Functions.SqlObj("CompanyId", "1"),
                         new Functions.SqlObj("CurrentAccountReceiptId", currentAccountReceiptRecId),
                         new Functions.SqlObj("ReceiptType", "50"),
                         new Functions.SqlObj("ReceiptDate", receiptDate),
                         new Functions.SqlObj("CurrentAccountId", currentAccountId),
                         new Functions.SqlObj("BankAccountId", bankAccountId), // 3=netspay, 1=albaaka
                         new Functions.SqlObj("ItemOrderNo", currentAccountReceiptItemNo),
                         new Functions.SqlObj("TermDate", receiptDate),
                         new Functions.SqlObj("DocumentNo", ""),
                         new Functions.SqlObj("ControlCode", "0"),
                         new Functions.SqlObj("Credit", debit),
                         new Functions.SqlObj("ForexCredit", "0"),
                         new Functions.SqlObj("Explanation", documentNo),
                         new Functions.SqlObj("IsApproved", "1"),
                         new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                         new Functions.SqlObj("InsertedBy", "24"),
                         new Functions.SqlObj("IsDeleted", "0"),
                         new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceiptItem", SqlObjCurrentAccountReceiptItem.ToArray());
                    
                    ///// update total credit downright
                    //double lastcredit;
                    //double creditDouble;
                    //string lastCreditString = Functions.executeScalar(connString, $"SELECT Credit FROM Erp_CurrentAccountReceipt WHERE RecId='{lastCurrentAccountReceiptId}'");
                    //double.TryParse(lastCreditString, out lastcredit);
                    //double.TryParse(debit, out creditDouble);

                    //if (lastcredit != 0) {
                    //    lastcredit += creditDouble;
                    //    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", $"RecId='{lastCurrentAccountReceiptId}'",
                    //                                        new Functions.SqlObj[] { new Functions.SqlObj("Credit", lastcredit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}

                    /// update  bank receipt sourceid
                    List<Functions.SqlObj> SqlObjBankReceiptUpdate = new List<Functions.SqlObj> {
                        new Functions.SqlObj("SourceId", currentAccountReceiptRecId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("UpdatedBy", "24")
                    };
                    Functions.updateSQL(connString, "Erp_BankReceipt", $@"RecId='{bankReceiptRecId}'", SqlObjBankReceiptUpdate.ToArray());

                    await Task.Delay(1);
                    result = true;
                    return result;
                }
                else {
                    /// no need to create new use old receipts

                    /// ///
                    /// bankrecipt item
                    /// ///
                    string bankReceiptItemOrderNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_BankReceiptItem 
                                                                                            WHERE BankReceiptId={lastBankReceiptId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(bankReceiptItemOrderNo)) {
                        bankReceiptItemOrderNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjBankReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("BankReceiptId", lastBankReceiptId),
                        new Functions.SqlObj("ReceiptType", "1"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("ReceiptSubType", "9"),
                        new Functions.SqlObj("BankAccountId", bankAccountId), //3-> netspay, 1-> albaraka
                        new Functions.SqlObj("ItemOrderNo", bankReceiptItemOrderNo),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("Explanation", documentNo),
                        new Functions.SqlObj("Status", "1"),
                        new Functions.SqlObj("TransactionType", "5"),
                        new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceiptItem", SqlObjBankReceiptItem.ToArray());

                    /// update  total debit downright
                    double lastDebit;
                    double debitDouble;
                    string lastDebitString = Functions.executeScalar(connString, $"SELECT Debit FROM Erp_BankReceipt WHERE RecId='{lastBankReceiptId}'");
                    double.TryParse(lastDebitString, out lastDebit);
                    double.TryParse(debit, out debitDouble);

                    if (lastDebit != 0) {
                        lastDebit += debitDouble;
                        Functions.updateSQL(connString, "Erp_BankReceipt", $"RecId = '{lastBankReceiptId}'",
                                                         new Functions.SqlObj[] { new Functions.SqlObj("Debit", lastDebit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    }


                    /// /// ///
                    /// currentaccountReceipt Item
                    /// ///
                    string currentAccountReceiptItemNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_CurrentAccountReceiptItem 
                                                                                                WHERE CurrentAccountReceiptId='{lastCurrentAccountReceiptId}' ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(currentAccountReceiptItemNo)) {
                        currentAccountReceiptItemNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItem = new List<Functions.SqlObj> {
                         new Functions.SqlObj("CompanyId", "1"),
                         new Functions.SqlObj("CurrentAccountReceiptId", lastCurrentAccountReceiptId),
                         new Functions.SqlObj("ReceiptType", "50"),
                         new Functions.SqlObj("ReceiptDate", receiptDate),
                         new Functions.SqlObj("CurrentAccountId", currentAccountId),
                         new Functions.SqlObj("BankAccountId", bankAccountId), // 3=netspay, 1=albaraka
                         new Functions.SqlObj("ItemOrderNo", currentAccountReceiptItemNo),
                         new Functions.SqlObj("TermDate", receiptDate),
                         new Functions.SqlObj("DocumentNo", ""),
                         new Functions.SqlObj("ControlCode", "0"),
                         new Functions.SqlObj("Credit", debit),
                         new Functions.SqlObj("ForexCredit", "0"),
                         new Functions.SqlObj("Explanation", documentNo),
                         new Functions.SqlObj("IsApproved", "1"),
                         new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                         new Functions.SqlObj("InsertedBy", "24"),
                         new Functions.SqlObj("IsDeleted", "0"),
                         new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceiptItem", SqlObjCurrentAccountReceiptItem.ToArray());

                    // not neccessary
                    ///// update total credit downright
                    //double lastcredit;
                    //double creditDouble;
                    //string lastCreditString = Functions.executeScalar(connString, $"SELECT Credit FROM Erp_CurrentAccountReceipt WHERE RecId='{lastCurrentAccountReceiptId}'");
                    //double.TryParse(lastCreditString, out lastcredit);
                    //double.TryParse(debit, out creditDouble);

                    //if (lastcredit != 0 /*||lastcredit != creditDouble*/) {
                    //    lastcredit += creditDouble;
                    //    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", $"RecId='{lastCurrentAccountReceiptId}'",
                    //                                        new Functions.SqlObj[] { new Functions.SqlObj("Credit", lastcredit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}

                    await Task.Delay(1);
                    result = true;
                    return result;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return result;
            }
            //return false;
        }
        
        private async static Task<bool> ProcessEft(string connString, string receiptDate, string debit, string currentAccountId, string documentNo, string bankAccountId = "1") {
            bool result = false; 
            try {
                //bool isTodaysReceiptExist = false;
                Tuple<string, string> tupleRecIds = FindLastReceiptsEft(connString);
                string lastCurrentAccountReceiptId = tupleRecIds.Item1;
                string lastBankReceiptId = tupleRecIds.Item2;
                if (string.IsNullOrEmpty(lastCurrentAccountReceiptId) || string.IsNullOrEmpty(lastBankReceiptId)) {
                    /// ///
                    /// currentaccountReceipt
                    /// ///
                    string currentAccountReceiptNo = Functions.executeScalar(connString, @"SELECT Top 1 ReceiptNo + 1 FROM Erp_CurrentAccountReceipt 
                                                                                            WHERE ReceiptType=25 ORDER BY RecId DESC;");
                    currentAccountReceiptNo = AddLeadingZerosToString(currentAccountReceiptNo, 8);
                    List<Functions.SqlObj> SqlObjCurrentAccountReceipt = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("WorkplaceId", "2"),
                        new Functions.SqlObj("ReceiptType", "25"),
                        new Functions.SqlObj("ReceiptNo", currentAccountReceiptNo),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
		                new Functions.SqlObj("ControlCode", "0"),
		                new Functions.SqlObj("DocumentNo", ""),
		                new Functions.SqlObj("Debit", "0"),
		                new Functions.SqlObj("Credit", debit),
		                new Functions.SqlObj("ForexDebit", "0"),
		                new Functions.SqlObj("ForexCredit", "0"),
		                new Functions.SqlObj("SourceModule", "15"),
		                //new Functions.SqlObj("SourceId", "71084"),///TODO!:update this
		                new Functions.SqlObj("IsApproved", "1"),
		                new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
		                new Functions.SqlObj("InsertedBy", "24"),
		                new Functions.SqlObj("IsDeleted", "0"),
		                new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceipt", SqlObjCurrentAccountReceipt.ToArray());
                    string currentAccountReceiptRecId = Functions.executeScalar(connString, @"SELECT RecId FROM Erp_CurrentAccountReceipt 
                                                                                                WHERE ReceiptType=25 ORDER BY RecId DESC;");
                    /// /// 
                    /// currentaccountReceipt Item
                    /// ///
                    string currentAccountReceiptItemNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_CurrentAccountReceiptItem 
                                                                                                WHERE CurrentAccountReceiptId={currentAccountReceiptRecId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(currentAccountReceiptItemNo)) {
                        currentAccountReceiptItemNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("WorkplaceId", "2"),
                        new Functions.SqlObj("CurrentAccountReceiptId", currentAccountReceiptRecId),
                        new Functions.SqlObj("ReceiptType", "25"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
		                new Functions.SqlObj("CurrentAccountId", currentAccountId),
		                new Functions.SqlObj("ItemOrderNo", currentAccountReceiptItemNo),
		                new Functions.SqlObj("TermDate", receiptDate),
		                new Functions.SqlObj("DocumentNo", ""),
		                new Functions.SqlObj("Explanation", documentNo),
		                new Functions.SqlObj("ControlCode", "0"),
		                new Functions.SqlObj("Credit", debit),
		                new Functions.SqlObj("ForexCredit", "0"),
		                new Functions.SqlObj("SourceModule", "15"),
		                new Functions.SqlObj("SourceType", "3"),
		                //new Functions.SqlObj("SourceId", "71084"),//TODO!: Update This from bankreceipt
		                //new Functions.SqlObj("SourceItemId", "87841"),//TODO!: Update This from bankreceiptitem
		                new Functions.SqlObj("IsApproved", "1"),
		                new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
		                new Functions.SqlObj("InsertedBy", "24"),
		                new Functions.SqlObj("IsDeleted", "0"),
		                new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceiptItem", SqlObjCurrentAccountReceiptItem.ToArray());
                    string currentAccountReceiptItemRecId = Functions.executeScalar(connString, $@"SELECT RecId
                                                                                                FROM Erp_CurrentAccountReceiptItem 
                                                                                                WHERE CurrentAccountReceiptId='{currentAccountReceiptRecId}' 
                                                                                                        AND ItemOrderNo='{currentAccountReceiptItemNo}';");

                    ///// update total credit downright
                    //double lastcredit;
                    //double creditDouble;
                    //string lastCreditString = Functions.executeScalar(connString, $"SELECT Credit FROM Erp_CurrentAccountReceipt WHERE RecId='{currentAccountReceiptRecId}'");
                    //double.TryParse(lastCreditString, out lastcredit);
                    //double.TryParse(debit, out creditDouble);

                    //if (lastcredit != 0 || lastcredit != creditDouble) {
                    //    lastcredit += creditDouble;
                    //    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", $"RecId='{currentAccountReceiptRecId}'",
                    //                                        new Functions.SqlObj[] { new Functions.SqlObj("Credit", lastcredit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}

                    /// ///
                    /// create bank receipt 
                    /// don't forget to update sourceid
                    /// ///
                    string bankReceiptNo = Functions.executeScalar(connString, @"SELECT Top 1 ReceiptNo + 1
                                                                                 FROM Erp_BankReceipt 
                                                                                 WHERE ReceiptType=3 ORDER BY RecId DESC;");
                    bankReceiptNo = AddLeadingZerosToString(bankReceiptNo, 8);
                    List<Functions.SqlObj> SqlObjBankReceipt = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("WorkplaceId", " 2"),
                        new Functions.SqlObj("ReceiptType", " 3"),
                        new Functions.SqlObj("ReceiptNo", bankReceiptNo),
                        new Functions.SqlObj("ReceiptDate", receiptDate), // TODO: ask muhasebe and decide
                        new Functions.SqlObj("DocumentNo", ""),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),// payment price ?
                        new Functions.SqlObj("Credit", "0"),// always 0
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("ForexCredit", "0"),
		                new Functions.SqlObj("CurrentAccountReceiptId", currentAccountReceiptRecId),
                        new Functions.SqlObj("IsApproved", " 1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", " 0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceipt", SqlObjBankReceipt.ToArray());
                    string bankReceiptRecId = Functions.executeScalar(connString, $"SELECT Top 1 RecId FROM Erp_BankReceipt WHERE ReceiptType=3 ORDER BY RecId DESC");

                    /// ///
                    /// bankrecipt item
                    /// ///
                    string bankReceiptItemOrderNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_BankReceiptItem 
                                                                                         WHERE BankReceiptId={bankReceiptRecId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(bankReceiptItemOrderNo)) {
                        bankReceiptItemOrderNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjBankReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("BankReceiptId", bankReceiptRecId),
                        new Functions.SqlObj("ReceiptType", "3"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("ReceiptSubType", "1"),
                        new Functions.SqlObj("BankAccountId", bankAccountId), //3-> netspay, 1-> albaraka
		                new Functions.SqlObj("CurrentAccountId", currentAccountId),
                        new Functions.SqlObj("ItemOrderNo", bankReceiptItemOrderNo),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),
                        new Functions.SqlObj("Explanation", documentNo),
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("Status", "1"),
                        new Functions.SqlObj("TransactionType", "1"),
                        new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceiptItem", SqlObjBankReceiptItem.ToArray());
                    string bankReceiptItemRecId = Functions.executeScalar(connString, "SELECT RecId FROM Erp_BankReceiptItem " +
                                                                                       $@"WHERE BankReceiptId={bankReceiptRecId} " + 
                                                                                        $@"AND ItemOrderNo = {bankReceiptItemOrderNo}");

                    ///// update  total debit downright
                    //double lastDebit;
                    //double debitDouble;
                    //string lastDebitString = Functions.executeScalar(connString, $"SELECT Debit FROM Erp_BankReceipt WHERE RecId='{bankReceiptRecId}'");
                    //double.TryParse(lastDebitString, out lastDebit);
                    //double.TryParse(debit, out debitDouble);

                    //if (lastDebit != 0) {
                    //    lastDebit += debitDouble;
                    //    Functions.updateSQL(connString, "Erp_BankReceipt", $"RecId = '{bankReceiptRecId}'",
                    //                                     new Functions.SqlObj[] { new Functions.SqlObj("Debit", lastDebit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}

                    /// update  currentaccuntrecipt receipt sourceid
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptUpdate = new List<Functions.SqlObj> {
                        new Functions.SqlObj("SourceId", bankReceiptRecId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("UpdatedBy", "24")
                    };
                    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", $@"RecId='{currentAccountReceiptRecId}'", SqlObjCurrentAccountReceiptUpdate.ToArray());

                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItemUpdate = new List<Functions.SqlObj> {
                        new Functions.SqlObj("SourceId", bankReceiptRecId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("SourceItemId", bankReceiptItemRecId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("UpdatedBy", "24")
                    };
                    Functions.updateSQL(connString, "Erp_CurrentAccountReceiptItem", $@"RecId='{currentAccountReceiptItemRecId}'", SqlObjCurrentAccountReceiptItemUpdate.ToArray());

                    await Task.Delay(1);
                    result = true;
                    return result;
                }
                else {

                    /// /// 
                    /// currentaccountReceipt Item
                    /// ///
                    string currentAccountReceiptItemNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_CurrentAccountReceiptItem 
                                                                                                WHERE CurrentAccountReceiptId={lastCurrentAccountReceiptId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(currentAccountReceiptItemNo)) {
                        currentAccountReceiptItemNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("CompanyId", "1"),
                        new Functions.SqlObj("WorkplaceId", "2"),
                        new Functions.SqlObj("CurrentAccountReceiptId", lastCurrentAccountReceiptId),
                        new Functions.SqlObj("ReceiptType", "25"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("CurrentAccountId", currentAccountId),
                        new Functions.SqlObj("ItemOrderNo", currentAccountReceiptItemNo),
                        new Functions.SqlObj("TermDate", receiptDate),
                        new Functions.SqlObj("DocumentNo", ""),
                        new Functions.SqlObj("Explanation", documentNo),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Credit", debit),
                        new Functions.SqlObj("ForexCredit", "0"),
                        new Functions.SqlObj("SourceModule", "15"),
                        new Functions.SqlObj("SourceType", "3"),
		                //new Functions.SqlObj("SourceId", "71084"),//TODO!: Update This from bankreceipt
		                //new Functions.SqlObj("SourceItemId", "87841"),//TODO!: Update This from bankreceiptitem
		                new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0")
                    };
                    Functions.insertToSQL(connString, "Erp_CurrentAccountReceiptItem", SqlObjCurrentAccountReceiptItem.ToArray());
                    string currentAccountReceiptItemRecId = Functions.executeScalar(connString, $@"SELECT RecId FROM Erp_CurrentAccountReceiptItem 
                                                                                    WHERE ReceiptType=25 AND ItemOrderNo={currentAccountReceiptItemNo} ORDER BY RecId DESC");

                    ///// update total credit downright
                    //double lastcredit;
                    //double creditDouble;
                    //string lastCreditString = Functions.executeScalar(connString, $"SELECT Credit FROM Erp_CurrentAccountReceipt WHERE RecId='{lastCurrentAccountReceiptId}'");
                    //double.TryParse(lastCreditString, out lastcredit);
                    //double.TryParse(debit, out creditDouble);

                    //if (lastcredit != 0) {
                    //    lastcredit += creditDouble;
                    //    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", $"RecId='{lastCurrentAccountReceiptId}'",
                    //                                        new Functions.SqlObj[] { new Functions.SqlObj("Credit", lastcredit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    //}



                    /// ///
                    /// bankrecipt item
                    /// ///
                    string bankReceiptItemOrderNo = Functions.executeScalar(connString, $@"SELECT Top 1 ItemOrderNo + 1 FROM Erp_BankReceiptItem 
                                                                                         WHERE BankReceiptId={lastBankReceiptId} ORDER BY RecId DESC;");
                    if (string.IsNullOrEmpty(bankReceiptItemOrderNo)) {
                        bankReceiptItemOrderNo = "1";
                    }
                    List<Functions.SqlObj> SqlObjBankReceiptItem = new List<Functions.SqlObj> {
                        new Functions.SqlObj("BankReceiptId", lastBankReceiptId),
                        new Functions.SqlObj("ReceiptType", "3"),
                        new Functions.SqlObj("ReceiptDate", receiptDate),
                        new Functions.SqlObj("ReceiptSubType", "9"),
                        new Functions.SqlObj("BankAccountId", bankAccountId), //3-> netspay, 1-> albaraka
                        new Functions.SqlObj("ItemOrderNo", bankReceiptItemOrderNo),
                        new Functions.SqlObj("ControlCode", "0"),
                        new Functions.SqlObj("Debit", debit),
                        new Functions.SqlObj("Explanation", documentNo),
                        new Functions.SqlObj("ForexDebit", "0"),
                        new Functions.SqlObj("Status", "1"),
                        new Functions.SqlObj("TransactionType", "1"),
                        new Functions.SqlObj("IsApproved", "1"),
                        new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("InsertedBy", "24"),
                        new Functions.SqlObj("IsDeleted", "0"),
                        new Functions.SqlObj("IsForexReceipt", "0"),
                        new Functions.SqlObj("CurrentAccountId", currentAccountId)
                    };
                    Functions.insertToSQL(connString, "Erp_BankReceiptItem", SqlObjBankReceiptItem.ToArray());
                    string bankReceiptItemRecId = Functions.executeScalar(connString, $@"SELECT RecId FROM Erp_BankReceiptItem 
                                                                                            WHERE ReceiptType = 3 AND ItemOrderNo = {bankReceiptItemOrderNo} ORDER BY RecId DESC");

                    /// update  total debit downright
                    double lastDebit;
                    double debitDouble;
                    string lastDebitString = Functions.executeScalar(connString, $"SELECT Debit FROM Erp_BankReceipt WHERE RecId='{lastBankReceiptId}'");
                    double.TryParse(lastDebitString, out lastDebit);
                    double.TryParse(debit, out debitDouble);

                    if (lastDebit != 0) {
                        lastDebit += debitDouble;
                        Functions.updateSQL(connString, "Erp_BankReceipt", $"RecId = '{lastBankReceiptId}'",
                                                         new Functions.SqlObj[] { new Functions.SqlObj("Debit", lastDebit.ToString("0.0000", CultureInfo.InvariantCulture)) });
                    }


                    /// update  currentaccuntrecipt receipt sourceid
                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptUpdate = new List<Functions.SqlObj> {
                        new Functions.SqlObj("SourceId", lastBankReceiptId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("UpdatedBy", "24")
                    };
                    Functions.updateSQL(connString, "Erp_CurrentAccountReceipt", 
                                        $@"RecId='{lastCurrentAccountReceiptId}'", SqlObjCurrentAccountReceiptUpdate.ToArray());

                    List<Functions.SqlObj> SqlObjCurrentAccountReceiptItemUpdate = new List<Functions.SqlObj> {
                        new Functions.SqlObj("SourceId", lastBankReceiptId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("SourceItemId", bankReceiptItemRecId), // Erp_Currentaccountreceipt recid
                        new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        new Functions.SqlObj("UpdatedBy", "24")
                    };
                    Functions.updateSQL(connString, "Erp_CurrentAccountReceiptItem",
                                        $@"RecId='{currentAccountReceiptItemRecId}'", SqlObjCurrentAccountReceiptItemUpdate.ToArray());


                    await Task.Delay(1);
                    result = true;
                    return result;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return result;
            }
            //return false;
        }


        /// helpers
        private /*async static Task<Tuple<string, string>>*/ static Tuple<string, string> FindLastReceipt(string connString) {
            //try {
            //    string lastCurrentAccountReceiptId = "";
            //    string lastbankReceiptId = "";
            //    DataTable dataTableLastReceipt = Functions.getDataFromSql(connString, @"SELECT Top 1 RecId, ReceiptDate 
            //                                                                            FROM Erp_CurrentAccountReceipt
            //                                                                            WHERE ReceiptType = 50 ORDER BY RecId DESC;");
            //    if (dataTableLastReceipt != null && dataTableLastReceipt.Rows.Count >= 1) {
            //        DateTime receiptDate = Convert.ToDateTime(dataTableLastReceipt.Rows[0]["ReceiptDate"].ToString());
            //        var diff = DateTime.Now.Subtract(receiptDate);
            //        if (diff.TotalMinutes < 1440) {
            //            /// use existing
            //            lastCurrentAccountReceiptId = dataTableLastReceipt.Rows[0]["RecId"].ToString();
            //            lastbankReceiptId = Functions.executeScalar(connString, $@"SELECT RecId FROM Erp_BankReceipt WHERE SourceId = {lastCurrentAccountReceiptId}");
            //        }
            //        else {
            //            lastCurrentAccountReceiptId = "";
            //        }
            //    }
            //    await Task.Delay(1);
            //    return new Tuple<string, string>(lastCurrentAccountReceiptId, lastbankReceiptId);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //    return new Tuple<string, string>("", "");
            //}
            //////////////////always create new
            return new Tuple<string, string>("", "");
        }

        private /*async static Task<Tuple<string, string>>*/ static Tuple<string, string> FindLastReceiptsEft(string connString) {
            //try {
            //    string lastCurrentAccountReceiptId = "";
            //    string lastbankReceiptId = "";
            //    DataTable dataTableLastReceipt = Functions.getDataFromSql(connString, @"SELECT Top 1 RecId, ReceiptDate 
            //                                                                            FROM Erp_BankReceipt
            //                                                                            WHERE ReceiptType = 3 ORDER BY RecId DESC;");
            //    if (dataTableLastReceipt != null && dataTableLastReceipt.Rows.Count >= 1) {
            //        DateTime receiptDate = Convert.ToDateTime(dataTableLastReceipt.Rows[0]["ReceiptDate"].ToString());
            //        var diff = DateTime.Now.Subtract(receiptDate);
            //        if (diff.TotalMinutes < 1440) {
            //            /// use existing
            //            lastCurrentAccountReceiptId = dataTableLastReceipt.Rows[0]["RecId"].ToString();
            //            lastCurrentAccountReceiptId = Functions.executeScalar(connString, $@"SELECT RecId FROM Erp_CurrentAccountReceipt WHERE SourceId={lastCurrentAccountReceiptId}");
            //            lastbankReceiptId = dataTableLastReceipt.Rows[0]["RecId"].ToString();
            //        }
            //        else {
            //            lastCurrentAccountReceiptId = "";
            //        }
            //    }
            //    await Task.Delay(1);
            //    return new Tuple<string, string>(lastCurrentAccountReceiptId, lastbankReceiptId);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //    return new Tuple<string, string>("", "");
            //}
            //////////////////always create new
            return new Tuple<string, string>("", "");
        }

        private static string AddLeadingZerosToString(string s, int digitLengt) {
            if (s.Length <= digitLengt) {
                var leadingZeros = digitLengt - s.Length;
                return new string('0', leadingZeros) + s;
            }
            else {
                return s;
            }
        }


    }
}
