using System;
using System.Collections.Generic;
using UGCore;

namespace UGDiscordBot {
    public static class InventoryReceipt {
        //private SqlObj sqlObj;        
        public static bool insertItemToInventoryReceiptOrn(string connString, string barcode, int quantity, string recId = "6") {
            bool result = false;
            try {
                if (string.IsNullOrEmpty(barcode) || string.IsNullOrWhiteSpace(barcode) || quantity <= 0) {
                    return false;
                }
                /// ReceiptID
                string itemInventoryReceiptId = Functions.executeScalar(connString, @"SELECT RecId FROM Erp_InventoryReceipt WHERE ReceiptType='120' and DocumentNo='discord'");
                /// item
                string itemInventoryId = Functions.executeScalar(connString, string.Format("SELECT RecId FROM dbo.Erp_Inventory WHERE InventoryCode = '{0}' ORDER BY RecId DESC", barcode));
                if (string.IsNullOrEmpty(itemInventoryReceiptId) || string.IsNullOrWhiteSpace(itemInventoryReceiptId) ||
                    string.IsNullOrEmpty(itemInventoryId) || string.IsNullOrWhiteSpace(itemInventoryId)) {
                    return false;
                }
                string itemReceiptDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemReceiptType = "120";
                string itemReceiptSubType = "0";
                string itemWarehouseId = "1";
                string itemItemType = "1";
                string itemUnitId = "51";
                string itemVatIncluded = "0";
                string itemCalcType = "0";
                string itemIsTaxExempted = "0";
                //string itemIsReserved = "1";
                //string itemIsClosed = "0";
                string itemIsApproved = "1";
                string itemControlCode = "0";
                string itemInsertedBy = recId;
                string itemIsDeleted = "0";
                string itemInsertedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //string itemIsWClosed = "0";

                int itemOrderNo = 0;
                int.TryParse(Functions.executeScalar(connString, @"SELECT ItemOrderNo FROM dbo.Erp_InventoryReceiptItem WHERE OrderReceiptId = '" + itemInventoryReceiptId + "' ORDER BY RecId DESC"), out itemOrderNo);
                string itemItemOrderNo = itemOrderNo++.ToString();


                string itemQuantity = quantity.ToString();
                string itemNetQuantity = quantity.ToString();
                //string itemUnitPrice = "0";
                //string itemVatRate = "0";
                //string itemExpenseRate = "0";
                string itemVatAmount = "0";
                string itemVatBaseAmount = "0";
                string itemItemTotal = "0";
                string itemDiscountsTotal = "0";
                string itemNetUnitPrice = "0";

                string itemHasNegativeEffect = "0";
                string itemExpensesTotal = "0.0";
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
                string itemIsQCApproved = "1";

                List<Functions.SqlObj> SqlObjReceiptItems = new List<Functions.SqlObj> {
                    new Functions.SqlObj("InventoryReceiptId", itemInventoryReceiptId, false),      new Functions.SqlObj("ReceiptType",itemReceiptType, false),
                    new Functions.SqlObj("ReceiptSubType", itemReceiptSubType, false),              new Functions.SqlObj("ReceiptDate", itemReceiptDate),
                    new Functions.SqlObj("ItemType", itemItemType, false),                          new Functions.SqlObj("ItemOrderNo", itemItemOrderNo,false),
                    new Functions.SqlObj("InventoryId", itemInventoryId, false),                    new Functions.SqlObj("UnitId", itemUnitId, false),
                    new Functions.SqlObj("Quantity", itemQuantity, false),                          new Functions.SqlObj("NetQuantity", itemQuantity, false),
                    new Functions.SqlObj("VatIncluded", itemVatIncluded, false),                    new Functions.SqlObj("CalcType", itemCalcType, false),
                    new Functions.SqlObj("VatAmount", itemVatAmount, false),                        new Functions.SqlObj("VatBaseAmount", itemVatBaseAmount, false),
                    new Functions.SqlObj("ItemTotal", itemItemTotal, false),                        new Functions.SqlObj("DiscountsTotal", itemDiscountsTotal, false),
                    new Functions.SqlObj("NetItemTotal", itemItemTotal, false),                     new Functions.SqlObj("IsTaxExempted", itemIsTaxExempted, false),
                    new Functions.SqlObj("IsApproved", itemIsApproved, false),                      new Functions.SqlObj("ControlCode", itemControlCode, false),
                    new Functions.SqlObj("InsertedAt", itemInsertedAt),                             new Functions.SqlObj("InsertedBy", itemInsertedBy, false),
                    new Functions.SqlObj("IsDeleted", itemIsDeleted, false),                        new Functions.SqlObj("HasNegativeEffect", itemHasNegativeEffect),
                    new Functions.SqlObj("IsQCApproved", itemIsQCApproved),                         new Functions.SqlObj("ExpensesTotal", itemExpensesTotal),
                    new Functions.SqlObj("NetUnitPrice", itemNetUnitPrice),                         new Functions.SqlObj("DistributedDiscount", itemDistributedDiscount),
                    new Functions.SqlObj("DistributedExpense", itemDistributedExpense),             new Functions.SqlObj("NetUnitPriceForex", itemNetUnitPriceForex),
                    new Functions.SqlObj("VatAmountForex", itemVatAmountForex),                     new Functions.SqlObj("VatBaseAmountForex", itemVatBaseAmountForex),
                    new Functions.SqlObj("ItemTotalForex", itemItemTotalForex),                     new Functions.SqlObj("DiscountsTotalForex", itemDiscountsTotalForex),
                    new Functions.SqlObj("ExpensesTotalForex", itemExpensesTotalForex),             new Functions.SqlObj("DistributedDiscountForex", itemDistributedDiscountForex),
                    new Functions.SqlObj("DistributedExpenseForex", itemDistributedExpenseForex),   new Functions.SqlObj("NetItemTotalForex", itemNetItemTotalForex),
                    new Functions.SqlObj("OutWarehouseId", itemWarehouseId)
                };
                Functions.insertToSQL(connString, "Erp_InventoryReceiptItem", SqlObjReceiptItems.ToArray());
                result = true;
            }
            catch (Exception) {
                result = false;
            }
            return result;
        }

        public static bool setItemQuantity(string connString, string barcode, int quantity, string recID= "6") {
            bool result = false;
            try {
                string currentAccountId = "424611";
                string documentNo = "";
                string receiptType = "";
                string warehouseIdColName = "";
                if (string.IsNullOrEmpty(barcode) || string.IsNullOrWhiteSpace(barcode)) {
                    return false;
                }
                if (quantity > 0) {
                    documentNo = "sayim+";
                    receiptType = "99";
                    warehouseIdColName = "InWarehouseId";
                }
                else if (quantity < 0) {
                    quantity = quantity * (-1);
                    documentNo = "sayim-";
                    receiptType = "101";
                    warehouseIdColName = "OutWarehouseId";
                }
                else {
                    return false;
                }
                /// ReceiptID
                string itemOrderReceiptId = Functions.executeScalar(connString,
                                            string.Format(@"SELECT RecId FROM dbo.Erp_InventoryReceipt WHERE CurrentAccountId='{0}' and DocumentNo='{1}' and ReceiptType='{2}' ORDER BY ReceiptDate DESC", 
                                                            currentAccountId, documentNo, receiptType));
                /// item
                string itemInventoryId = Functions.executeScalar(connString, string.Format("SELECT RecId FROM dbo.Erp_Inventory WHERE InventoryCode = '{0}' ORDER BY RecId DESC", barcode));
                if (string.IsNullOrEmpty(itemOrderReceiptId) || string.IsNullOrWhiteSpace(itemOrderReceiptId) ||
                    string.IsNullOrEmpty(itemInventoryId) || string.IsNullOrWhiteSpace(itemInventoryId)) {
                    return false;
                }

                int itemOrderNo = 0;
                int.TryParse(Functions.executeScalar(connString, string.Format(@"SELECT ItemOrderNo FROM dbo.Erp_InventoryReceiptItem WHERE InventoryReceiptId='{0}' ORDER BY RecId DESC", itemOrderReceiptId)), out itemOrderNo);

                string itemItemOrderNo = itemOrderNo++.ToString();
                string itemReceiptDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemReceiptType = receiptType;
                string itemReceiptSubType = "0";
                string itemItemType = "1";
                string itemUnitId = "51";
                string itemVatIncluded = "0";
                string itemCalcType = "0";
                string itemIsTaxExempted = "0";
                string itemIsApproved = "1";
                string itemControlCode = "0";
                string itemInsertedBy = recID;
                string itemIsDeleted = "0";
                string itemInsertedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string itemQuantity = quantity.ToString();
                string itemNetQuantity = quantity.ToString();
                string itemVatAmount = "0";
                string itemVatBaseAmount = "0";
                string itemItemTotal = "0";
                string itemDiscountsTotal = "0";

                string itemWarehouseId = "1";
                string itemHasNegativeEffect = "0";
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
                string itemIsQCApproved = "1";

                //sayimmm kaydet
                List<Functions.SqlObj> SqlObjReceiptItems = new List<Functions.SqlObj> {
                    new Functions.SqlObj("InventoryReceiptId", itemOrderReceiptId, false),          new Functions.SqlObj("ReceiptType",itemReceiptType, false),
                    new Functions.SqlObj("ReceiptSubType", itemReceiptSubType, false),              new Functions.SqlObj("ReceiptDate", itemReceiptDate),
                    new Functions.SqlObj("ItemType", itemItemType, false),                          new Functions.SqlObj("ItemOrderNo", itemItemOrderNo,false),
                    new Functions.SqlObj("InventoryId", itemInventoryId, false),                    new Functions.SqlObj("UnitId", itemUnitId, false),
                    new Functions.SqlObj("Quantity", itemQuantity, false),                          new Functions.SqlObj("NetQuantity", itemQuantity, false),
                    new Functions.SqlObj("VatIncluded", itemVatIncluded, false),                    new Functions.SqlObj("CalcType", itemCalcType, false),
                    new Functions.SqlObj("VatAmount", itemVatAmount, false),                        new Functions.SqlObj("VatBaseAmount", itemVatBaseAmount, false),
                    new Functions.SqlObj("ItemTotal", itemItemTotal, false),                        new Functions.SqlObj("DiscountsTotal", itemDiscountsTotal, false),
                    new Functions.SqlObj("NetItemTotal", itemItemTotal, false),                     new Functions.SqlObj("IsTaxExempted", itemIsTaxExempted, false),
                    new Functions.SqlObj("IsApproved", itemIsApproved, false),                      new Functions.SqlObj("ControlCode", itemControlCode, false),
                    new Functions.SqlObj("InsertedAt", itemInsertedAt),                             new Functions.SqlObj("InsertedBy", itemInsertedBy, false),
                    new Functions.SqlObj("IsDeleted", itemIsDeleted, false),                        new Functions.SqlObj("HasNegativeEffect", itemHasNegativeEffect),
                    new Functions.SqlObj("IsQCApproved", itemIsQCApproved),                         new Functions.SqlObj("ExpensesTotal", itemExpensesTotal),
                    new Functions.SqlObj("NetUnitPrice", itemNetUnitPrice),                         new Functions.SqlObj("DistributedDiscount", itemDistributedDiscount),
                    new Functions.SqlObj("DistributedExpense", itemDistributedExpense),             new Functions.SqlObj("NetUnitPriceForex", itemNetUnitPriceForex),
                    new Functions.SqlObj("VatAmountForex", itemVatAmountForex),                     new Functions.SqlObj("VatBaseAmountForex", itemVatBaseAmountForex),
                    new Functions.SqlObj("ItemTotalForex", itemItemTotalForex),                     new Functions.SqlObj("DiscountsTotalForex", itemDiscountsTotalForex),
                    new Functions.SqlObj("ExpensesTotalForex", itemExpensesTotalForex),             new Functions.SqlObj("DistributedDiscountForex", itemDistributedDiscountForex),
                    new Functions.SqlObj("DistributedExpenseForex", itemDistributedExpenseForex),   new Functions.SqlObj("NetItemTotalForex", itemNetItemTotalForex),
                    new Functions.SqlObj(warehouseIdColName, itemWarehouseId)
                };
                Functions.insertToSQL(connString, "Erp_InventoryReceiptItem", SqlObjReceiptItems.ToArray());
                result = true;
            }
            catch (Exception) {
                result = false;
            }
            return result;
        }


    }
}
