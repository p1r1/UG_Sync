using System;
using System.Collections.Generic;
using System.Data;
using UGCore;

namespace UGDiscordBot {
    public static class QuotationReceipt {
        public static bool addQuotationItem(string barcode, int quantity, string recId = "6") {
            SqlObj sql = new SqlObj(); ;
            bool result = false;
            try {
                sql.initalizeSqlConnection(Functions.GetConnString("ms_sql"));
                sql.openConnection();
                /// ReceiptID
                sql.selectString(@"SELECT RecId FROM dbo.Erp_QuotationReceipt WHERE CurrentAccountId='60' and DocumentNo='teklif' and ReceiptType='1'", true);
                string quotationReceiptId = sql.scalarStringGet;

                /// item
                sql.selectTable(string.Format("SELECT RecId, MarkId FROM dbo.Erp_Inventory WHERE InventoryCode = '{0}' ORDER BY RecId DESC", barcode), true);
                DataTable tableInventory = sql.dataTableGet;
                string itemInventoryId = tableInventory.Rows[0]["RecId"].ToString();
                string itemMarkId = tableInventory.Rows[0]["MarkId"].ToString();

                if (string.IsNullOrEmpty(quotationReceiptId) || string.IsNullOrWhiteSpace(quotationReceiptId) ||
                    string.IsNullOrEmpty(itemInventoryId) || string.IsNullOrWhiteSpace(itemInventoryId)) {
                    return false;
                }

                int itemOrderNo = 0;
                sql.selectString(string.Format(@"SELECT ItemOrderNo FROM dbo.Erp_QuotationReceiptItem WHERE QuotationReceiptId='{0}' ORDER BY RecId DESC", quotationReceiptId), true);
                int.TryParse(sql.scalarStringGet, out itemOrderNo);

                string itemItemOrderNo = itemOrderNo++.ToString();
                string itemReceiptDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemReceiptType = "1";
                string itemReceiptSubType = "0";
                string itemItemType = "1";
                string itemUnitId = "51";
                string itemVatIncluded = "0";
                string itemCalcType = "0";
                string itemIsTaxExempted = "0";
                string itemIsApproved = "1";
                string itemInsertedBy = recId;
                string itemIsDeleted = "0";
                string itemInsertedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemQuantity = quantity.ToString();
                string itemNetQuantity = quantity.ToString();
                string itemVatAmount = "0";
                string itemVatBaseAmount = "0";
                string itemItemTotal = "0";
                string itemDiscountsTotal = "0";

                string itemExpensesTotal = "0.0";
                string itemNetUnitPrice = "0.0";
                string itemDistributedDiscount = "0.0";
                string itemDistributedExpense = "0.0";
                string itemNetUnitPriceForex = "0.0";
                string itemVatAmountForex = "0.0";
                string itemVatBaseAmountForex = "0.0";
                string itemItemTotalForex = "0.0";
                string itemDiscountsTotalForex = "0.0";
                string itemExpensesTotalForex = "0.0";
                string itemDistributedDiscountForex = "0.0";
                string itemDistributedExpenseForex = "0.0";
                string itemNetItemTotalForex = "0.0";

                string itemExpenseRate = "0";
                string itemPeriodEndDate = new DateTime(DateTime.Now.Year, 12, 31).ToString("yyyy-MM-dd HH:mm:ss");
                string itemPeriodStartDate = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy-MM-dd HH:mm:ss");
                string itemUnitPrice = "0";
                string itemUpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemUpdatedBy = "6";
                string itemVatRate = "0";
                string itemWarehouseId = "3";

                //sayimmm kaydet
                List<SqlObj.SqlPair> SqlObjReceiptItems = new List<SqlObj.SqlPair> {
                    new SqlObj.SqlPair("QuotationReceiptId", quotationReceiptId),                 new SqlObj.SqlPair("ReceiptType",itemReceiptType),
                    new SqlObj.SqlPair("ReceiptSubType", itemReceiptSubType),                     new SqlObj.SqlPair("ReceiptDate", itemReceiptDate),
                    new SqlObj.SqlPair("ItemType", itemItemType),                                 new SqlObj.SqlPair("ItemOrderNo", itemItemOrderNo),
                    new SqlObj.SqlPair("InventoryId", itemInventoryId),                           new SqlObj.SqlPair("UnitId", itemUnitId),
                    new SqlObj.SqlPair("Quantity", itemQuantity),                                 new SqlObj.SqlPair("NetQuantity", itemQuantity),
                    new SqlObj.SqlPair("VatIncluded", itemVatIncluded),                           new SqlObj.SqlPair("CalcType", itemCalcType),
                    new SqlObj.SqlPair("VatAmount", itemVatAmount),                               new SqlObj.SqlPair("VatBaseAmount", itemVatBaseAmount),
                    new SqlObj.SqlPair("ItemTotal", itemItemTotal),                               new SqlObj.SqlPair("DiscountsTotal", itemDiscountsTotal),
                    new SqlObj.SqlPair("NetItemTotal", itemItemTotal),                            new SqlObj.SqlPair("IsTaxExempted", itemIsTaxExempted),
                    new SqlObj.SqlPair("IsApproved", itemIsApproved),                             /*new SqlObj.SqlPair("ControlCode", itemControlCode),*/
                    new SqlObj.SqlPair("InsertedAt", itemInsertedAt),                             new SqlObj.SqlPair("InsertedBy", itemInsertedBy),
                    new SqlObj.SqlPair("IsDeleted", itemIsDeleted),                               /*new SqlObj.SqlPair("HasNegativeEffect", itemHasNegativeEffect),*/
                   /*new SqlObj.SqlPair("IsQCApproved", itemIsQCApproved),*/                      new SqlObj.SqlPair("ExpensesTotal", itemExpensesTotal),
                    new SqlObj.SqlPair("NetUnitPrice", itemNetUnitPrice),                         new SqlObj.SqlPair("DistributedDiscount", itemDistributedDiscount),
                    new SqlObj.SqlPair("DistributedExpense", itemDistributedExpense),             new SqlObj.SqlPair("NetUnitPriceForex", itemNetUnitPriceForex),
                    new SqlObj.SqlPair("VatAmountForex", itemVatAmountForex),                     new SqlObj.SqlPair("VatBaseAmountForex", itemVatBaseAmountForex),
                    new SqlObj.SqlPair("ItemTotalForex", itemItemTotalForex),                     new SqlObj.SqlPair("DiscountsTotalForex", itemDiscountsTotalForex),
                    new SqlObj.SqlPair("ExpensesTotalForex", itemExpensesTotalForex),             new SqlObj.SqlPair("DistributedDiscountForex", itemDistributedDiscountForex),
                    new SqlObj.SqlPair("DistributedExpenseForex", itemDistributedExpenseForex),   new SqlObj.SqlPair("NetItemTotalForex", itemNetItemTotalForex),
                    new SqlObj.SqlPair("MarkId", itemMarkId),                                     new SqlObj.SqlPair("ExpenseRate", itemExpenseRate),
                    new SqlObj.SqlPair("PeriodEndDate", itemPeriodEndDate),                       new SqlObj.SqlPair("PeriodStartDate", itemPeriodStartDate),
                    new SqlObj.SqlPair("UnitPrice", itemUnitPrice),                               new SqlObj.SqlPair("UpdatedAt", itemUpdatedAt),
                    new SqlObj.SqlPair("UpdatedBy", itemUpdatedBy),                               new SqlObj.SqlPair("VatRate", itemVatRate),
                    new SqlObj.SqlPair("WarehouseId", itemWarehouseId)
                };
                sql.insert("dbo.Erp_QuotationReceiptItem", SqlObjReceiptItems, true);
                result = true;
            }
            catch (Exception) {
                result = false;
            }
            return result;
        }
    }
}
