using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x0200015A RID: 346
	[XmlInclude(typeof(WeightNumericType))]
	[XmlInclude(typeof(SequenceNumericType))]
	[XmlInclude(typeof(ResidentOccupantsNumericType))]
	[XmlInclude(typeof(ReminderSequenceNumericType))]
	[XmlInclude(typeof(PackSizeNumericType))]
	[XmlInclude(typeof(OrderQuantityIncrementNumericType))]
	[XmlInclude(typeof(OrderIntervalDaysNumericType))]
	[XmlInclude(typeof(MultiplierFactorNumericType))]
	[XmlInclude(typeof(MinimumNumberNumericType))]
	[XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
	[XmlInclude(typeof(MaximumNumberNumericType))]
	[XmlInclude(typeof(MaximumCopiesNumericType))]
	[XmlInclude(typeof(LineNumberNumericType))]
	[XmlInclude(typeof(LineCountNumericType))]
	[XmlInclude(typeof(FrozenPeriodDaysNumericType))]
	[XmlInclude(typeof(CalculationSequenceNumericType))]
	[XmlInclude(typeof(BudgetYearNumericType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(TypeName = "NumericType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class NumericType1 : NumericType
	{
	}
}
