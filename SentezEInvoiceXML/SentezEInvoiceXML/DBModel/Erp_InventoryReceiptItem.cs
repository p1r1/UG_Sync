﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    public class Erp_InventoryReceiptItem {
        public int RecId { get; set; }
        public int InventoryReceiptId { get; set; }
        public int ReceiptType { get; set; }
        public int ReceiptSubType { get; set; }
        public DateTime ReceiptDate { get; set; }
        public object HasNegativeEffect { get; set; }
        public object InWarehouseId { get; set; }
        public int OutWarehouseId { get; set; }
        public object InWarehouseLocationId { get; set; }
        public object OutWarehouseLocationId { get; set; }
        public int ItemType { get; set; }
        public object ParentItemId { get; set; }
        public int ItemOrderNo { get; set; }
        public int InventoryId { get; set; }
        public int UnitId { get; set; }
        public object ServiceCardId { get; set; }
        public object ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public object PackagingId { get; set; }
        public object RecipeId { get; set; }
        public object LabRecipeId { get; set; }
        public object PatternRecipeId { get; set; }
        public object RouteId { get; set; }
        public object InventoryAssortmentId { get; set; }
        public object CostCenterId { get; set; }
        public object PaymentPlanId { get; set; }
        public object MarkId { get; set; }
        public object ModelId { get; set; }
        public object CustomerId { get; set; }
        public object ReturnTypeId { get; set; }
        public string SpecialCode { get; set; }
        public int ComplimentaryType { get; set; }
        public object Explanation { get; set; }
        public object ExplanationCode { get; set; }
        public object SeatNo { get; set; }
        public object PackingStartTime { get; set; }
        public object PackedTime { get; set; }
        public object IsPacked { get; set; }
        public object CustomerOrderNo { get; set; }
        public int EntryCount { get; set; }
        public object CheckPrintCount { get; set; }
        public object IsMarched { get; set; }
        public object PartyNo { get; set; }
        public object PackageNo { get; set; }
        public float Quantity { get; set; }
        public float NetQuantity { get; set; }
        public object LotQuantity { get; set; }
        public object PackageQuantity { get; set; }
        public object GrossQuantity { get; set; }
        public object UsedQuantity { get; set; }
        public object ReturnedQuantity { get; set; }
        public object OpeningQuantity { get; set; }
        public object InflowQuantity { get; set; }
        public object OutflowQuantity { get; set; }
        public object TransferInflowQuantity { get; set; }
        public object TransferOutflowQuantity { get; set; }
        public float UnitPrice { get; set; }
        public object ForexId { get; set; }
        public object ForexRate { get; set; }
        public object ForexUnitPrice { get; set; }
        public int VatIncluded { get; set; }
        public decimal VatRate { get; set; }
        public int CalcType { get; set; }
        public object DiscountId { get; set; }
        public object DiscountRate { get; set; }
        public object DiscountAmount { get; set; }
        public object ExpenseId { get; set; }
        public object ExpenseRate { get; set; }
        public object ExpenseAmount { get; set; }
        public float VatAmount { get; set; }
        public float VatBaseAmount { get; set; }
        public object ExciseTaxRate { get; set; }
        public object ExciseTaxAmount { get; set; }
        public object CommunicationTaxRate { get; set; }
        public object CommunicationTaxAmount { get; set; }
        public float ItemTotal { get; set; }
        public float ItemTotalVatIncluded { get; set; }
        public float DiscountsTotal { get; set; }
        public float ExpensesTotal { get; set; }
        public float NetUnitPrice { get; set; }
        public object PreviousCostPrice { get; set; }
        public object CostPrice { get; set; }
        public object CostForexPrice { get; set; }
        public object CostPrice2 { get; set; }
        public object CostPrice3 { get; set; }
        public float DistributedDiscount { get; set; }
        public float DistributedExpense { get; set; }
        public float NetItemTotal { get; set; }
        public float NetUnitPriceForex { get; set; }
        public float VatAmountForex { get; set; }
        public float VatBaseAmountForex { get; set; }
        public object DiscountAmountForex { get; set; }
        public float ItemTotalForex { get; set; }
        public float ItemTotalVatIncludedForex { get; set; }
        public float DiscountsTotalForex { get; set; }
        public float ExpensesTotalForex { get; set; }
        public float DistributedDiscountForex { get; set; }
        public float DistributedExpenseForex { get; set; }
        public float NetItemTotalForex { get; set; }
        public object CreatedBySystem { get; set; }
        public object PackagingNo { get; set; }
        public object PackageMark { get; set; }
        public object ProcessId { get; set; }
        public object InventoryCampaignId { get; set; }
        public object ManufactureReceiptItemId { get; set; }
        public object ReturnReceiptItemId { get; set; }
        public object ReturnReceiptItemIdP { get; set; }
        public object TransferOutReceiptItemId { get; set; }
        public object OrderReceiptItemId { get; set; }
        public object DemandReceiptItemId { get; set; }
        public object WorkOrderReceiptItemId { get; set; }
        public object BoxId { get; set; }
        public object InvoiceItemId { get; set; }
        public object CtspId { get; set; }
        public int IsTaxExempted { get; set; }
        public int IsPrinted { get; set; }
        public object IsClosed { get; set; }
        public int IsQCApproved { get; set; }
        public object IsChecked { get; set; }
        public object IsSendOkc { get; set; }
        public object IsTrasnfered { get; set; }
        public object IsMerged { get; set; }
        public object IsSecondHandSale { get; set; }
        public int IsApproved { get; set; }
        public object ApprovedAt { get; set; }
        public object ApprovedBy { get; set; }
        public object ControlCode { get; set; }
        public object VatListField01 { get; set; }
        public object VatListField02 { get; set; }
        public object VatListField03 { get; set; }
        public object VatListField04 { get; set; }
        public object VatListField05 { get; set; }
        public object WithholdingAmount1 { get; set; }
        public object WithholdingAmount2 { get; set; }
        public object WithholdingAmount1Forex { get; set; }
        public object WithholdingAmount2Forex { get; set; }
        public object ExpenseTotalIsEffective { get; set; }
        public object IsCancelled { get; set; }
        public object DeliveryType { get; set; }
        public object PackageType { get; set; }
        public object TransportType { get; set; }
        public object CountingType { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public int IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
        public object UniqueId { get; set; }
        public int WorkplaceId { get; set; }
        public int DepartmentId { get; set; }
        public int CashId { get; set; }
        public object PreparedType { get; set; }
        public object PreparedAt { get; set; }
        public object ResourceId { get; set; }
        public object QualityTypeId { get; set; }
        public object ReservedReceiptItemId { get; set; }
        public object ReservedQuantity { get; set; }
        public object ApprovedExplanation { get; set; }
        public float DiscountVatIncluded { get; set; }
        public float DiscountsTotalVatIncluded { get; set; }
        public float DistributedDiscountVatIncluded { get; set; }
        public object DiscountVatIncludedForex { get; set; }
        public float DiscountsTotalVatIncludedForex { get; set; }
        public float DistributedDiscountVatIncludedForex { get; set; }
        public object VatRateAccommodation { get; set; }
        public float VatAmountAccommodation { get; set; }
        public float VatAmountAccommodationForex { get; set; }
        public object UsedEmployeeId { get; set; }
        public object CancelledExplanation { get; set; }
    }

}
