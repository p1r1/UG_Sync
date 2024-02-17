using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x02000148 RID: 328
	[XmlInclude(typeof(TargetCurrencyBaseRateType))]
	[XmlInclude(typeof(SourceCurrencyBaseRateType))]
	[XmlInclude(typeof(RateType1))]
	[XmlInclude(typeof(OrderableUnitFactorRateType))]
	[XmlInclude(typeof(CalculationRateType))]
	[XmlInclude(typeof(AmountRateType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class RateType : NumericType
	{
	}
}
