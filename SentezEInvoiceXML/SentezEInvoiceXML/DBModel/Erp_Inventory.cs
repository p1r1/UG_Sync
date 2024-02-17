﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentezEInvoiceXML {
    class Erp_Inventory {
        public int RecId { get; set; }
        public int CompanyId { get; set; }
        public int InventoryType { get; set; }
        public int InventorySubType { get; set; }
        public string InventoryCode { get; set; }
        public string InventoryName { get; set; }
        public int GroupId { get; set; }
        public int CategoryId { get; set; }
        public object PluCode { get; set; }
        public object AccessCode { get; set; }
        public int IsClass { get; set; }
        public object ParentId { get; set; }
        public int UnitId { get; set; }
        public object TaxId { get; set; }
        public int HasVatPositiveEffect { get; set; }
        public int VatId { get; set; }
        public int RetailVatId { get; set; }
        public int RetailReturnVatId { get; set; }
        public int WholeSaleVatId { get; set; }
        public int WholeSaleReturnVatId { get; set; }
        public int HasVariant { get; set; }
        public int HasRowVariant { get; set; }
        public int HasSeries { get; set; }
        public int HasSeparableSeries { get; set; }
        public int IsWithholdable { get; set; }
        public object WithholdingFactor { get; set; }
        public object WithholdingDivisor { get; set; }
        public object ProducerInventoryCode { get; set; }
        public object CurrentAccountId { get; set; }
        public object CtspId { get; set; }
        public int Tracking { get; set; }
        public int IsQCRequried { get; set; }
        public int IsTool { get; set; }
        public int IsPackagingMaterial { get; set; }
        public int DepreciationType { get; set; }
        public object DepreciationRate { get; set; }
        public object DepreciationPeriod { get; set; }
        public object SalvageValue { get; set; }
        public int Revaluation { get; set; }
        public int PartialDepreciation { get; set; }
        public int IsBuilding { get; set; }
        public DateTime DepreciationStartDate { get; set; }
        public DateTime DepreciationEndDate { get; set; }
        public object PurchaseCost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public object PurchaseDocument { get; set; }
        public object PurchaseAmount { get; set; }
        public DateTime SoldDate { get; set; }
        public object SoldDocument { get; set; }
        public object SoldAmount { get; set; }
        public object ShelfLife { get; set; }
        public int ShelfLifeUnit { get; set; }
        public int UseForCommon { get; set; }
        public int UseForPurchase { get; set; }
        public int UseForSale { get; set; }
        public object RouteId { get; set; }
        public int MarkId { get; set; }
        public object ModelId { get; set; }
        public object SeasonId { get; set; }
        public string SeasonCode { get; set; }
        public object CampaignGroup { get; set; }
        public string PriceGroup { get; set; }
        public string IsoDocumentNo { get; set; }
        public string WebContent { get; set; }
        public object SymbolId { get; set; }
        public object UsefulServiceLifeId { get; set; }
        public string SText { get; set; }
        public string CText { get; set; }
        public object Variant1TypeId { get; set; }
        public object Variant2TypeId { get; set; }
        public object Variant3TypeId { get; set; }
        public object Variant4TypeId { get; set; }
        public object Variant5TypeId { get; set; }
        public int Variant1TypeControlType { get; set; }
        public int Variant2TypeControlType { get; set; }
        public int Variant3TypeControlType { get; set; }
        public int Variant4TypeControlType { get; set; }
        public int Variant5TypeControlType { get; set; }
        public int IsTaxGrossQuantity { get; set; }
        public object GrossQuantityTax { get; set; }
        public object LocalCurrencyForexRate2 { get; set; }
        public object LocalCurrencyForexRate3 { get; set; }
        public int InUse { get; set; }
        public int IsLocked { get; set; }
        public string SpecialCode { get; set; }
        public object RecipeQuantity { get; set; }
        public object RecipeUnitItemId { get; set; }
        public object RecipeCostPrice { get; set; }
        public object RevisionNumber { get; set; }
        public int IsChecked { get; set; }
        public int IsApproved { get; set; }
        public int IsPublishWeb { get; set; }
        public object IsPiecesProduct { get; set; }
        public object IsWeightedProduct { get; set; }
        public object PreparationTime { get; set; }
        public object LockedAt { get; set; }
        public object LockedBy { get; set; }
        public DateTime InsertedAt { get; set; }
        public int InsertedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public object IsDeleted { get; set; }
        public object DeletedAt { get; set; }
        public object DeletedBy { get; set; }
        public object UniqueId { get; set; }
        public object ProcessId { get; set; }
        public object DegreeOfDifficulty { get; set; }
        public object WorkplaceId { get; set; }
    }

}
