using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGCore {
    public static class UGSync_DeleteOrder {
        public static string Delete(string SpecialCode, int DaysAgo = 3) {
            Console.WriteLine("Delete order begins");
            string resultString = "";
            try {
                if (DateTime.Now.TimeOfDay >= new TimeSpan(23, 59, 0) || DateTime.Now.TimeOfDay <= new TimeSpan(06, 0, 0)) {
                    resultString += "Gece çalışmaz!, ";
                    Console.WriteLine(resultString);
                    return resultString;
                }
                if (DaysAgo == 0) {
                    DaysAgo = 3;
                }
                if (string.IsNullOrEmpty(SpecialCode)) {
                    resultString += "SpecialCode is empty!, ";
                    Console.WriteLine(resultString);
                    return resultString;
                }

                /// ///
                /// Check if Receipt Exist
                /// ///
                /// Count Check
                string queryInventoryReceipt = $"select RecId, CurrentAccountId from Erp_InventoryReceipt where SpecialCode='{SpecialCode}' and ReceiptType='120'";
                DataTable InventoryReceiptData = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), queryInventoryReceipt);
                string InventoryReceiptRecId = "";
                string CurrentAccountId = "";
                if (ReferenceEquals(null, InventoryReceiptData) ||
                    ReferenceEquals(null, InventoryReceiptData.Rows) ||
                    InventoryReceiptData.Rows.Count != 1) {
                    resultString += "InventoryReceipt count is wrong!, ";
                    Console.WriteLine(resultString);
                    return resultString;
                }
                else {
                    InventoryReceiptRecId = InventoryReceiptData.Rows[0]["RecId"].ToString();
                    CurrentAccountId = InventoryReceiptData.Rows[0]["CurrentAccountId"].ToString();
                }

                /// Data Check
                if (string.IsNullOrEmpty(InventoryReceiptRecId) ||
                    string.IsNullOrEmpty(CurrentAccountId)) {
                    resultString += "InventoryReceipt data is wrong!, ";
                    Console.WriteLine(resultString);
                    return resultString;
                }
                else {
                    /// continue
                    Console.WriteLine("deleteable");
                }

                /// check if payment is exists then do not delete - return
                string queryPayment = $"select RecId from Erp_CurrentAccountReceiptItem where CurrentAccountId={CurrentAccountId} and ReceiptType='50'";
                string CurrentAccountPaymentItem = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryPayment);

                string queryPayment22 = $"select RecId from Erp_BankReceiptItem where CurrentAccountId={CurrentAccountId} and ReceiptType='3'";
                string BankreceiptItem = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryPayment22);
                if (!string.IsNullOrEmpty(CurrentAccountPaymentItem) || !string.IsNullOrEmpty(BankreceiptItem)) {
                    resultString += "Payment exist nothing to do!-> false, ";
                    Console.WriteLine(resultString);
                    return resultString;
                }

                /// ////
                /// Invoice
                /// ///
                string queryInvoice = $"select RecId from Erp_Invoice where SpecialCode='{SpecialCode}'";
                string InvoiceRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryInvoice);
                if (string.IsNullOrEmpty(InvoiceRecId)) {
                    resultString += "InvoiceRecId is empty!, ";
                    Console.WriteLine(resultString);
                    //return result;
                }
                else {
                    /// ///
                    /// Check Einvoice Status
                    /// ///
                    string endDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string startDate = DateTime.Now.AddDays(-1 * DaysAgo).ToString("yyyy-MM-dd HH:mm:ss");
                    string queryEInvoiceCheck = $"select RecId from Erp_Invoice where SpecialCode='{SpecialCode}' and " + 
                                                $"ReceiptDate between '{startDate}' and '{endDate}' and " + 
                                                $"EInvoiceStatus not in (3,5,6,7,8) and UD_EInvoiceIntegratorInvoiceId is null";
                    Console.WriteLine(queryEInvoiceCheck);
                    DataTable InvoiceData = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), queryEInvoiceCheck);
                    if (ReferenceEquals(null, InvoiceData) ||
                        ReferenceEquals(null, InvoiceData.Rows) ||
                        InvoiceData.Rows.Count != 1) {
                        resultString += "ReceiptDate is late or EinvoiceStatus data is wrong! or UD_EInvoiceIntegratorInvoiceId is not null!, ";
                        Console.WriteLine(resultString);
                        return resultString;
                    }
                    else {
                        if (string.IsNullOrEmpty(InvoiceData.Rows[0]["RecId"].ToString())) {
                            resultString += "ReceiptDate is late or EinvoiceStatus data is wrong! or UD_EInvoiceIntegratorInvoiceId is not null!, ";
                            Console.WriteLine(resultString);
                            return resultString;
                        }
                    }


                    /// CurrentAccountReceiptItem
                    string queryCurrentAccountReceiptItem2 = $"select RecId from Erp_CurrentAccountReceiptItem where SpecialCode='{SpecialCode}'";
                    string CurrentAccountReceiptRecId2 = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryCurrentAccountReceiptItem2);
                    if (string.IsNullOrEmpty(CurrentAccountReceiptRecId2)) {
                        resultString += "CurrentAccountReceiptRecId is empty!, ";
                        Console.WriteLine(resultString);
                        //return result;
                    }
                    else {
                        bool func1 = DeleteCurrentAccountReceiptItem(SpecialCode);
                        resultString += $"DeleteCurrentAccountReceiptItem {queryCurrentAccountReceiptItem2}-> " + func1.ToString() + ", ";
                    }

                    /// ReceiptPaymentItem
                    string queryReceiptPayment = $"select RecId from Erp_ReceiptPaymentItem where SpecialCode='{SpecialCode}'";
                    string ReceiptPaymentItemRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryReceiptPayment);
                    if (string.IsNullOrEmpty(ReceiptPaymentItemRecId)) {
                        resultString += "ReceiptPaymentItemRecId is empty!, ";
                        Console.WriteLine(resultString);
                        //return result;
                    }
                    else {
                        bool func2 = DeleteReceiptPaymentItem(SpecialCode);
                        resultString += $"DeleteReceiptPaymentItem -> {queryReceiptPayment}" + func2.ToString() + ", ";
                        Console.WriteLine();
                    }

                    /// Invoice
                    bool func25 = UpdateInvoiceIdToNull(SpecialCode);
                    resultString += "UpdateInvoiceIdToNull -> " + func25.ToString() + ", ";
                    bool func3 = DeleteInvoice(SpecialCode);
                    resultString += $"DeleteInvoice {InvoiceRecId}-> " + func3.ToString() + ", ";
                }

                /// ///
                /// InventoryReceipt
                /// ///
                /// 

                /// InventoryReceipt Items
                string queryReceiptItems = $"select RecId from Erp_InventoryReceiptItem where InventoryReceiptId='{InventoryReceiptRecId}'";
                string ReceiptItemRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryReceiptItems);
                if (string.IsNullOrEmpty(ReceiptItemRecId)) {
                    resultString += "ReceiptItemsRecId is empty!, ";
                    Console.WriteLine(resultString);
                    //return result;
                }
                else {
                    bool func4 = DeleteReceiptItems(InventoryReceiptRecId);
                    resultString += $"DeleteReceiptItems {queryReceiptItems}-> " + func4.ToString() + ", ";
                }
                /// ReceiptAttachments
                string queryReceiptAttachments = $"select RecId from Erp_InventoryReceiptAttachment where InventoryReceiptId='{InventoryReceiptRecId}'";
                string ReceiptAttachmentsRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryReceiptAttachments);
                if (string.IsNullOrEmpty(ReceiptAttachmentsRecId)) {
                    resultString += "ReceiptAttachmentsRecId is empty!, ";
                    Console.WriteLine(resultString);
                    //return result;
                }
                else {
                    bool func5 = DeleteReceiptAttachments(InventoryReceiptRecId);
                    resultString += $"DeleteReceiptAttachments {queryReceiptAttachments}-> " + func5.ToString() + ", ";
                }
                /// Receipt
                bool func6 = DeleteReceipt(SpecialCode);
                resultString += $"DeleteReceipt -> {InventoryReceiptRecId}" + func6.ToString() + ", ";

                /// ///
                /// Account
                /// ///
                string queryCurrentAccount = $"select RecId from Erp_CurrentAccount where RecId='{CurrentAccountId}'";// redundant ?
                string CurrentAccountRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryCurrentAccount);
                if (string.IsNullOrEmpty(CurrentAccountRecId)) {
                    resultString += "ReceiptAttachmentsRecId is empty!, ";
                    Console.WriteLine(resultString);
                    //return result;
                }
                else {
                    /// Account Total
                    string queryCurrentAccountTotal = $"select RecId from Erp_CurrentAccountTotal where CurrentAccountId='{CurrentAccountRecId}'";
                    string CurrentAccountTotalId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryCurrentAccountTotal);
                    if (string.IsNullOrEmpty(CurrentAccountTotalId)) {
                        resultString += "Erp_CurrentAccountTotal is empty!, ";
                        Console.WriteLine(resultString);
                    }
                    else {
                        DeleteCurrentAccountTotal(CurrentAccountRecId);
                        resultString += $"DeleteCurrentAccountTotal -> {CurrentAccountRecId}";
                    }


                    /// Account Adress
                    string queryAddresses = $"select RecId from Erp_Address where CurrentAccountId='{CurrentAccountRecId}'";
                    string AddressesRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryAddresses);
                    if (string.IsNullOrEmpty(AddressesRecId)) {
                        resultString += "AddressesRecId is empty!, ";
                        Console.WriteLine(resultString);
                        //return result;
                    }
                    else {
                        bool func7 = DeleteAddresses(CurrentAccountRecId);
                        resultString += $"DeleteAddresses {queryAddresses}-> " + func7.ToString() + ", ";
                    }

                    /// CurrentAccountReceiptItem with curren account id
                    string queryCurrentAccountReceiptItem = $"select RecId from Erp_CurrentAccountReceiptItem where CurrentAccountId='{CurrentAccountRecId}'";
                    string CurrentAccountReceiptRecId = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryCurrentAccountReceiptItem);
                    if (string.IsNullOrEmpty(CurrentAccountReceiptRecId)) {
                        resultString += "CurrentAccountReceiptRecId is empty!, ";
                        Console.WriteLine(resultString);
                        //return result;
                    }
                    else {
                        bool func1 = DeleteCurrentAccountReceiptItemWithCurrentAccountId(CurrentAccountRecId);
                        resultString += $"DeleteCurrentAccountReceiptItem {queryCurrentAccountReceiptItem}-> " + func1.ToString() + ", ";
                    }

                    /// Current account total
                    try {
                        string queryCurrentAccountTotal2 = $"select RecId from Erp_CurrentAccountTotal where CurrentAccountId='{CurrentAccountRecId}'";
                        string CurrentAccountTotalId2 = Functions.executeScalar(Functions.GetConnString("ms_sql"), queryCurrentAccountTotal2);
                        if (string.IsNullOrEmpty(CurrentAccountTotalId2)) {
                            resultString += "Erp_CurrentAccountTotal2 is empty!, ";
                            Console.WriteLine(resultString);
                        }
                        else {
                            bool func75 = DeleteCurrentAccountTotal2(CurrentAccountRecId);
                            resultString += $"DeleteCurrentAccountTotal2 -> {func75}";
                        }
                    }
                    catch { }

                    /// Account
                    bool func8 = DeleteCurrentAccount(CurrentAccountRecId);
                    resultString += $"DeleteCurrentAccount {CurrentAccountId}-> " + func8.ToString() + ", ";
                }



            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                resultString += ex + ", ";
            }
            return resultString;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////
        /// Invoice
        /// remove invoiceId in InventoryReceipt
        private static bool UpdateInvoiceIdToNull(string SpecialCode) {
            bool result;
            try {
                string where = $"SpecialCode='{SpecialCode}'";
                string querySelect = $"select count(RecId) as count from Erp_InventoryReceipt where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), $"UPDATE Erp_InventoryReceipt SET InvoiceId = NULL WHERE {where}");
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteCurrentAccountReceiptItem(string SpecialCode) {
            bool result;
            try {
                string where = $"SpecialCode='{SpecialCode}'";
                string querySelect = $"select count(RecId) as count from Erp_CurrentAccountReceiptItem where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    string queryDelete = $"delete from Erp_CurrentAccountReceiptItem where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteCurrentAccountReceiptItemWithCurrentAccountId(string curretAccountId) {
            bool result;
            try {
                string where = $"CurrentAccountId='{curretAccountId}'";
                string querySelect = $"select count(RecId) as count from Erp_CurrentAccountReceiptItem where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    string queryDelete = $"delete from Erp_CurrentAccountReceiptItem where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteReceiptPaymentItem(string SpecailCode) {
            bool result;
            try {
                string where = $"SpecialCode='{SpecailCode}'";
                string querySelect = $"select count(RecId) as count from Erp_ReceiptPaymentItem where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                    Console.WriteLine("select not matched");
                }
                else {
                    string queryDelete = $"delete from Erp_ReceiptPaymentItem where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteInvoice(string SpecialCode) {
            bool result;
            try {
                string where = $"SpecialCode='{SpecialCode}'";
                string querySelect = $"select count(RecId) as count from Erp_Invoice where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    string queryDelete = $"delete from Erp_Invoice where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        /// Receipt
        private static bool DeleteReceiptItems(string ReceiptRecId) {//multi
            bool result;
            try {
                string querySelect = $"select RecId from Erp_InventoryReceiptItem where InventoryReceiptId='{ReceiptRecId}'";
                DataTable dataTable = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querySelect);
                if (dataTable.Rows.Count < 1 || dataTable.Rows.Count > 30) {
                    result = false;
                    Console.WriteLine("if row count bigger than 30 do NOT delete");
                }
                else {
                    string RecIds = "";
                    for (int i = 0; i < dataTable.Rows.Count; i++) {
                        RecIds += dataTable.Rows[i]["RecId"].ToString() + ",";
                    }
                    RecIds = RecIds.Remove(RecIds.LastIndexOf(','));
                    string queryDelete = $"delete from Erp_InventoryReceiptItem where RecId in ({RecIds})";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteReceiptAttachments(string ReceiptRecId) {//multi
            bool result;
            try {
                string querySelect = $"select RecId from Erp_InventoryReceiptAttachment where InventoryReceiptId='{ReceiptRecId}'";
                DataTable dataTable = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querySelect);
                if (dataTable.Rows.Count < 1 || dataTable.Rows.Count > 4) {
                    result = false;
                    Console.WriteLine("if row count bigger than 4 do NOT delete");
                }
                else {
                    string RecIds = "";
                    for (int i = 0; i < dataTable.Rows.Count; i++) {
                        RecIds += dataTable.Rows[i]["RecId"].ToString() + ",";
                    }
                    RecIds = RecIds.Remove(RecIds.LastIndexOf(','));
                    string queryDelete = $"delete from Erp_InventoryReceiptAttachment where RecId in ({RecIds})";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteReceipt(string SpecialCode) {
            bool result;
            try {
                string where = $"SpecialCode='{SpecialCode}'";
                string querySelect = $"select count(RecId) as count from Erp_InventoryReceipt where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    string queryDelete = $"delete from Erp_InventoryReceipt where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        /// Account
        private static bool DeleteAddresses(string CurrentAccountRecId) {//multi
            bool result;
            try {
                string querySelect = $"select RecId from Erp_Address where CurrentAccountId='{CurrentAccountRecId}'";
                DataTable dataTable = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querySelect);
                if (dataTable.Rows.Count < 1 || dataTable.Rows.Count > 10) {
                    result = false;
                    Console.WriteLine("if row count bigger than 10 do NOT delete");
                }
                else {
                    string RecIds = "";
                    for (int i = 0; i < dataTable.Rows.Count; i++) {
                        RecIds += dataTable.Rows[i]["RecId"].ToString() + ",";
                    }
                    RecIds = RecIds.Remove(RecIds.LastIndexOf(','));
                    string queryDelete = $"delete from Erp_Address where RecId in ({RecIds})";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteCurrentAccountTotal(string CurrentAccountRecId) {
            bool result;
            try {
                string where = $"CurrentAccountId='{CurrentAccountRecId}'";
                string querySelect = $"select RecId from Erp_CurrentAccountTotal where {where}";
                DataTable dataTable = Functions.getDataFromSql(Functions.GetConnString("ms_sql"), querySelect);
                if (dataTable.Rows.Count < 1 /*|| dataTable.Rows.Count > 3*/) {
                    result = false;
                    Console.WriteLine("if row count lower than 1");
                }
                else {
                    string RecIds = "";
                    for (int i = 0; i < dataTable.Rows.Count; i++) {
                        RecIds += dataTable.Rows[i]["RecId"].ToString() + ",";
                    }
                    RecIds = RecIds.Remove(RecIds.LastIndexOf(','));
                    string queryDelete = $"delete from Erp_CurrentAccountTotal where RecId in ({RecIds})";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }

        private static bool DeleteCurrentAccountTotal2(string CurrentAccountRecId) {
            try {
                string query = $"select RecId from Erp_CurrentAccountTotal where CurrentAccountId='{CurrentAccountRecId}'";
                string recId = Functions.executeScalar(Functions.GetConnString("ms_sql"), query);
                if (!string.IsNullOrEmpty(recId)) {
                    ///!Empty 
                    string queryDelete = $"delete from Erp_CurrentAccountTotal where CurrentAccountId='{CurrentAccountRecId}'";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex);
                return false;
            }
        }

        private static bool DeleteCurrentAccount(string CurrentAccountRecId) {
            bool result;
            try {
                string where = $"RecId='{CurrentAccountRecId}'";
                string querySelect = $"select count(RecId) as count from Erp_CurrentAccount where {where}";
                string count = Functions.executeScalar(Functions.GetConnString("ms_sql"), querySelect);
                if (string.IsNullOrEmpty(count) || count != "1") {
                    result = false;
                }
                else {
                    string queryDelete = $"delete from Erp_CurrentAccount where {where}";
                    Functions.sendSQLCommand(Functions.GetConnString("ms_sql"), queryDelete);
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                result = false;
            }
            return result;
        }



    }
}
