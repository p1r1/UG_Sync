using System;
using System.Collections.Generic;

namespace UGCore {
    public static partial class UGSync_Order {
		/// ///
		/// Current Account Receipt Item
		/// ///
		public static bool InsertCurrentAccountReceiptItem(string connString,
														     string ReceiptDate,
														     string CurrentAccountId, 
														     string SpecialCode, 
														     string Debit, 
														     string ProjectId) {
			bool result;
            try {
				/// check if exist
				string queryExist = "select RecId from Erp_CurrentAccountReceiptItem " + 
									$"where CurrentAccountId={CurrentAccountId} and ReceiptType='21' and SpecialCode='{SpecialCode}' and Debit={Debit} and SourceModule='11' and SourceType='120'";
				string RecIdExist = Functions.executeScalar(connString, queryExist);
				if (!string.IsNullOrEmpty(RecIdExist)) {
					Console.WriteLine("this receipt item already exist");
					result = true;
					return result;
				}

				Functions.SqlObj[] SqlObjCurrentAccountReceiptItem = new Functions.SqlObj[] {
					new Functions.SqlObj("CompanyId", "1"),
					new Functions.SqlObj("ReceiptType", "21"),
					new Functions.SqlObj("ReceiptDate", ReceiptDate),
					new Functions.SqlObj("CurrentAccountId", CurrentAccountId),
					new Functions.SqlObj("TermDate", ReceiptDate),
					new Functions.SqlObj("DocumentNo", ""),
					new Functions.SqlObj("Explanation", "-120"),
					new Functions.SqlObj("SpecialCode", SpecialCode),
					new Functions.SqlObj("ControlCode", "0"),
					new Functions.SqlObj("Debit", Debit),
					new Functions.SqlObj("Credit", "0"),
					new Functions.SqlObj("ForexRate", "0"),
					new Functions.SqlObj("ForexDebit", "0"),
					new Functions.SqlObj("ForexCredit", "0"),
					new Functions.SqlObj("SourceModule", "11"),
					new Functions.SqlObj("SourceType", "120"),
					/*new Functions.SqlObj("SourceId", "177587"),// needs update*/
					new Functions.SqlObj("IsApproved", "1"),
					new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
					new Functions.SqlObj("InsertedBy", "24"),
					new Functions.SqlObj("IsDeleted", "0"),
					new Functions.SqlObj("IsForexReceipt", "0"),
					new Functions.SqlObj("ProjectId", ProjectId)
				};
				Functions.insertToSQL(connString, "Erp_CurrentAccountReceiptItem", SqlObjCurrentAccountReceiptItem);
				result = true;									
			}
            catch (Exception ex) {
				Console.WriteLine(ex);
				result = false;
				
            }
			return result;
		}

		public static bool UpdateCurrentAccountReceipt(string connString, string RecId, string SourceId, string DocumentNo) {
			bool result = false; 
            try {
				Functions.SqlObj[] sqlObjs = new Functions.SqlObj[] {
					new Functions.SqlObj("SourceId", SourceId),
					new Functions.SqlObj("DocumentNo", DocumentNo),
					new Functions.SqlObj("Explanation", DocumentNo + "-120"),
					new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
					new Functions.SqlObj("UpdatedBy", "24"),
				};
				Functions.updateSQL(connString, "Erp_CurrentAccountReceiptItem", $"RecId = '{RecId}'", sqlObjs);
				result = true;
			}
            catch (Exception ex) {
				Console.WriteLine(ex);
				result = false;

			}
			return result;
        }

		public static bool InsertReceiptPaymentItem(string connString,
													string invoiceRecId,
													string receiptDate,
													string receiptGrandTotal,
													string paymentType,
													string currentAccountId,
													string specialCode) {
			bool result = false;
            try {
				/// check if exist
				string queryExist = "select RecId from Erp_ReceiptPaymentItem " + 
									$"where SourceId={invoiceRecId} and SourceModule='11' and Amount={receiptGrandTotal} and CurrentAccountId={currentAccountId} and SpecialCode='{specialCode}'";
				string RecIdExist = Functions.executeScalar(connString, queryExist);
				if (!string.IsNullOrEmpty(RecIdExist)) {
					Console.WriteLine("this receipt item already exist");
					result = true;
					return result;
				}

				Functions.SqlObj[] SqlObjInvoice = new Functions.SqlObj[] {
					new Functions.SqlObj("SourceModule", "11"),
					new Functions.SqlObj("SourceId", invoiceRecId),
					new Functions.SqlObj("ItemOrderNo", "1"),
					new Functions.SqlObj("TermDate", receiptDate),
					new Functions.SqlObj("Amount", receiptGrandTotal),
					new Functions.SqlObj("ForexAmount", "0"),
					new Functions.SqlObj("PaymentType", paymentType), // PaymentType
					new Functions.SqlObj("Explanation", "Toplam Tutar"),
					new Functions.SqlObj("CDType", "0"),
					new Functions.SqlObj("CurrentAccountId", currentAccountId),
					new Functions.SqlObj("IsPaymentPlanning", "0"),
					new Functions.SqlObj("IsOutOfCalculate", "0"),
					new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
					new Functions.SqlObj("InsertedBy", "24"),
					new Functions.SqlObj("ControlCode", "0"),
					new Functions.SqlObj("SpecialCode", specialCode),
				};
				Functions.insertToSQL(connString, "Erp_ReceiptPaymentItem", SqlObjInvoice);
				result = true;
			}
            catch (Exception ex) {
				Console.WriteLine(ex);
				result = false;
            }
			return result;
		}


		/// ///
		/// Invoice 
		/// ///
        public static bool InsertInvoice(string connString,
										   bool hasVATException,
										   string ReceiptDate, 
										   string ReceiptTime, 
										   string CurrentAccountId, 
										   string AddressId, 
										   string ShipToCurrentAccountId, 
										   string ShipToAddressId, 
										   string PaymentPlanId, 
										   string CustomerOrderNo, 
										   string SpecialCode, 
										   string TransporterId, 
										   string Explanation, 
										   string SubTotal, 
										   string VatAmount, 
										   string DiscountsTotal, 
										   string GrandTotal, 
										   string CurrentAccountReceiptId, 
										   string EArchivesPaymentType, 
										   string SubTotalVatIncluded,
										   string ProjectId,
										   string PaymentToCurrentAccountId,
										   string EArchivesCargoId) {
			bool result;
            try {
				/// check if exist
				string queryExist = "";
				if (string.IsNullOrEmpty(PaymentToCurrentAccountId)) {
					queryExist = "select RecId from Erp_Invoice " +
									$"where ReceiptType='120' and CurrentAccountId={CurrentAccountId} and AddressId={AddressId} and ShipToCurrentAccountId={ShipToCurrentAccountId} and " +
									$"SpecialCode='{SpecialCode}' and GrandTotal={GrandTotal}  and PaymentPlanId={PaymentPlanId} and " +
									$"DiscountsTotal={DiscountsTotal} and SubTotal={SubTotal}";
                }
                else {
					queryExist = "select RecId from Erp_Invoice " +
									$"where ReceiptType='120' and CurrentAccountId={CurrentAccountId} and AddressId={AddressId} and ShipToCurrentAccountId={ShipToCurrentAccountId} and " +
									$"SpecialCode='{SpecialCode}' and GrandTotal={GrandTotal} and PaymentToCurrentAccountId={PaymentToCurrentAccountId} and PaymentPlanId={PaymentPlanId} and " +
									$"DiscountsTotal={DiscountsTotal} and SubTotal={SubTotal}";
				}
								
				string RecIdExist = Functions.executeScalar(connString, queryExist);
				if (!string.IsNullOrEmpty(RecIdExist)) {
					Console.WriteLine("this receipt item already exist");
					result = true;
					return result;
				}

				string ReceiptNo = MakeInvoiceReceiptNo(connString);
				if (string.IsNullOrEmpty(ReceiptNo)) {
					result = false;
					return result;
				}

				// check isEfatura  2 - earchive 1-efatura
				string isEinvoice = Functions.executeScalar(connString, $"SELECT IsEInvoice FROM Erp_CurrentAccount WHERE RecId={CurrentAccountId};" );
				Tuple<string, int> tupleDocumentNoEInvoiceNo = null;
                if (isEinvoice == "1") {
					tupleDocumentNoEInvoiceNo = MakeInvoiceDocumentNo(connString, "UGF");
				}
                else {
					// 2 - earchive - default
					tupleDocumentNoEInvoiceNo = MakeInvoiceDocumentNo(connString);
				}
               
				if (string.IsNullOrEmpty(tupleDocumentNoEInvoiceNo.Item1)) {
					result = false;
					return result;
				}

				// check if eInvoice - if acount -> IsEInvoice = 1 then  IsEInvoice = 1
				string isEInvoice = "2"; // earşiv
				string isEInvoiceString = Functions.executeScalar(connString, $"select IsEInvoice from Erp_CurrentAccount where RecId='{CurrentAccountId}'");
                if (string.IsNullOrEmpty(isEInvoiceString) || string.IsNullOrWhiteSpace(isEInvoiceString)) {
					isEInvoice = "2";
				}
                else {
                    if (isEInvoiceString == "1") {
						isEInvoice = "1";// efatura
					}
                }

				List<Functions.SqlObj> SqlObjInvoice = new List<Functions.SqlObj> {
					new Functions.SqlObj("CompanyId", "1"),
					new Functions.SqlObj("ReceiptType", "120"),
					new Functions.SqlObj("ReceiptNo", ReceiptNo),
					new Functions.SqlObj("ReceiptSubType", "0"),
					new Functions.SqlObj("ReceiptDate", ReceiptDate),
					new Functions.SqlObj("ReceiptTime", ReceiptTime),
					new Functions.SqlObj("DocumentNo", tupleDocumentNoEInvoiceNo.Item1),
					new Functions.SqlObj("CurrentAccountId", CurrentAccountId),
					new Functions.SqlObj("AddressId", AddressId),
					new Functions.SqlObj("ShipToCurrentAccountId", ShipToCurrentAccountId),
					new Functions.SqlObj("ShipToAddressId", ShipToAddressId),
					new Functions.SqlObj("OutWarehouseId", "1"),
					new Functions.SqlObj("PaymentPlanId", PaymentPlanId),
					new Functions.SqlObj("CustomerOrderNo", CustomerOrderNo),
					new Functions.SqlObj("SpecialCode", SpecialCode),
					new Functions.SqlObj("ProjectId", ProjectId),
					new Functions.SqlObj("EmployeeId", "13"),
					new Functions.SqlObj("TransporterId", TransporterId),
					new Functions.SqlObj("HasNegativeEffect", "0"),
					new Functions.SqlObj("Explanation", Explanation),
					new Functions.SqlObj("TermDate", ReceiptDate),
					new Functions.SqlObj("IsTaxExempted", "0"),
					new Functions.SqlObj("SubTotal", SubTotal),
					new Functions.SqlObj("VatAmount", VatAmount),
					new Functions.SqlObj("WithholdingAmount1", "0"),
					new Functions.SqlObj("WithholdingAmount2", "0"),
					new Functions.SqlObj("Rate1Amount", "0"),
					new Functions.SqlObj("Rate2Amount", "0"),
					new Functions.SqlObj("Rate3Amount", "0"),
					new Functions.SqlObj("Rate4Amount", "0"),
					new Functions.SqlObj("Rate5Amount", "0"),
					new Functions.SqlObj("ExciseTaxAmount", "0"),
					new Functions.SqlObj("CommunicationTaxAmount", "0"),
					new Functions.SqlObj("DistributedDiscountsTotal", "0"),
					new Functions.SqlObj("DiscountsTotal", DiscountsTotal),
					new Functions.SqlObj("DiscountsTotalGross", "0"),
					new Functions.SqlObj("DistributedExpensesTotal", "0"),
					new Functions.SqlObj("ExpensesTotal", "0"),
					new Functions.SqlObj("GrandTotal", GrandTotal),
					new Functions.SqlObj("SubTotalForex", "0"),
					new Functions.SqlObj("VatAmountForex", "0"),
					new Functions.SqlObj("WithholdingAmount1Forex", "0"),
					new Functions.SqlObj("WithholdingAmount2Forex", "0"),
					new Functions.SqlObj("Rate1AmountForex", "0"),
					new Functions.SqlObj("Rate2AmountForex", "0"),
					new Functions.SqlObj("Rate3AmountForex", "0"),
					new Functions.SqlObj("Rate4AmountForex", "0"),
					new Functions.SqlObj("Rate5AmountForex", "0"),
					new Functions.SqlObj("ExciseTaxAmountForex", "0"),
					new Functions.SqlObj("CommunicationTaxAmountForex", "0"),
					new Functions.SqlObj("DistributedDiscountsTotalForex", "0"),
					new Functions.SqlObj("DiscountsTotalForex", "0"),
					new Functions.SqlObj("DiscountsTotalGrossForex", "0"),
					new Functions.SqlObj("DistributedExpensesTotalForex", "0"),
					new Functions.SqlObj("ExpensesTotalForex", "0"),
					new Functions.SqlObj("GrandTotalForex", "0"),
					new Functions.SqlObj("CurrentAccountReceiptId", CurrentAccountReceiptId),
					new Functions.SqlObj("IsEximReceipt", "0"),
					new Functions.SqlObj("IsBrokerageInvoice", "0"),
					new Functions.SqlObj("IsExportRegistered", "0"),
					new Functions.SqlObj("IsApproved", "1"),
					new Functions.SqlObj("ControlCode", "0"),
					new Functions.SqlObj("IsCancelled", "0"),
					new Functions.SqlObj("IsETrade", "1"), /// check mark in sentez
					new Functions.SqlObj("IsEInvoice", isEInvoice), /// 1-> Einvoice , 2-> Earchive
					new Functions.SqlObj("IsESendMail", "0"),
					new Functions.SqlObj("EInvoiceStatus", "0"), /// why 1?
					/*new Functions.SqlObj("EInvoiceGuid", "2e32db12-9307-4462-b348-09374b75305e"), //make update */ 
					//new Functions.SqlObj("EInvoiceNo", tupleDocumentNoEInvoiceNo.Item2.ToString()),//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
					new Functions.SqlObj("EArchivesShippingType", "ELEKTRONIK"),
					new Functions.SqlObj("EArchivesWebAddress", "uzaktangelir.com"),
					new Functions.SqlObj("EArchivesPaymentType", EArchivesPaymentType),
					new Functions.SqlObj("EArchivesSendDate", ReceiptDate), //when earchive send this can write ??
					new Functions.SqlObj("EArchivesCargoId", EArchivesCargoId),// 18 -> ptt kargo
					new Functions.SqlObj("InsertedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
					new Functions.SqlObj("InsertedBy", "24"),
					new Functions.SqlObj("IsDeleted", "0"),
					new Functions.SqlObj("SubTotalVatIncluded", SubTotalVatIncluded),
					new Functions.SqlObj("SubTotalVatIncludedForex", "0"),
					new Functions.SqlObj("DiscountsTotalVatIncluded", "0"),
					new Functions.SqlObj("DiscountsTotalVatIncludedForex", "0"),
					new Functions.SqlObj("VatAmountAccommodation", "0"),
					new Functions.SqlObj("WorkplaceId", "2"),
					new Functions.SqlObj("VatAmountAccommodationForex", "0"),
					new Functions.SqlObj("ForexRate", "0"),
					new Functions.SqlObj("IsForexReceipt", "0"),
					new Functions.SqlObj("EInvoiceScenario", "1"),//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
					new Functions.SqlObj("WithholdingType", "0")
					//UniqueId //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
				};
                if (hasVATException) {
					SqlObjInvoice.Add(new Functions.SqlObj("EInvoiceTaxExemptionReasonCode", "335"));
				}
                if (!string.IsNullOrEmpty(PaymentToCurrentAccountId)) {
					SqlObjInvoice.Add(new Functions.SqlObj("PaymentToCurrentAccountId", PaymentToCurrentAccountId));//nestpay paratika
				}
				Functions.insertToSQL(connString, "Erp_Invoice", SqlObjInvoice.ToArray());
				result = true;
			}
            catch (Exception ex) {
				Console.WriteLine(ex);
				result = false;
            }
			return result;
        }
		
		/// helpers
		private static string MakeInvoiceReceiptNo(string connString) {
            try {
				long ReceiptNo = 0;
				string ReceiptNoString = Functions.executeScalar(connString, "select ReceiptNo from Erp_Invoice where ReceiptType='120' order by ReceiptNo desc");
                if (!string.IsNullOrEmpty(ReceiptNoString)) {
					long.TryParse(ReceiptNoString, out ReceiptNo);
                    if (ReceiptNo != 0) {
						return (ReceiptNo + 1).ToString("00000000");
                    }
                    else {
						return "";
                    }
                }
                else {
					return "";
                }
			}
            catch (Exception ex) {
				Console.WriteLine(ex);  
				return "";
            }
		}

		private static Tuple<string, int> MakeInvoiceDocumentNo(string connString, string docStart="UGE") {
            try {
				string docNoTemplate = docStart + DateTime.Now.Year;
				string lastDocNo = Functions.executeScalar(connString,
								   $@"SELECT DocumentNo FROM Erp_Invoice WHERE DocumentNo LIKE '{docNoTemplate}%' ORDER BY DocumentNo DESC");

				string receiptCurrentDocNo = "";
				int x;
				if (string.IsNullOrEmpty(lastDocNo)) {
					receiptCurrentDocNo = docNoTemplate + "000000001";
					x = 1;
				}
				else {
					x = Convert.ToInt32(lastDocNo.Substring(lastDocNo.Length - 8));
					x++;
					receiptCurrentDocNo = docNoTemplate + x.ToString("000000000");
				}
				return new Tuple<string, int>(receiptCurrentDocNo, x);
			}
            catch (Exception ex) {
				Console.WriteLine(ex);
				return null;
            }
		}

		public static bool UpdateEInvoiceUUIDandEInvoiceStatus(string connString, string RecId, string EInvoiceGuid) {
			bool result = false; ;
			try {
				Functions.SqlObj[] sqlObjs = new Functions.SqlObj[] {
					new Functions.SqlObj("EInvoiceGuid", EInvoiceGuid),
					new Functions.SqlObj("EInvoiceStatus", "1"),
					new Functions.SqlObj("UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
					new Functions.SqlObj("UpdatedBy", "24"),
				};
				Functions.updateSQL(connString, "Erp_Invoice", $"RecId = '{RecId}'", sqlObjs);
				result = true;
			}
			catch (Exception ex) {
				Console.WriteLine(ex);
				result = false;

			}
			return result;
		}

		public static bool DeleteCARI_InventoryREceipt(string connString, string IRRecId, string CurrentAccountReceiptId_fromIR) {
            try {
				/// update irsaliye CurrentAccountReceiptId
				Functions.SqlObj2[] sqlObjs = new Functions.SqlObj2[] {
					new Functions.SqlObj2("CurrentAccountReceiptId", DBNull.Value)
				};
				Functions.updateSQL2(connString, "Erp_InventoryReceipt", $"RecId = '{IRRecId}'", sqlObjs);

				/// delete currentAccountReceiptItem
				string sql_delete = $"DELETE FROM Erp_CurrentAccountReceiptItem WHERE RecId='{CurrentAccountReceiptId_fromIR}';";
				Functions.sendSQLCommand(connString, sql_delete);
				return true;
            }
            catch (Exception ex) {
				Console.WriteLine(ex);
				return false;
            }

		}


    }
}
