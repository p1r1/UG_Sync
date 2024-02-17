using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SentezEInvoiceXML
{
	// Token: 0x020001AC RID: 428
	[XmlInclude(typeof(VesselNameType))]
	[XmlInclude(typeof(TechnicalNameType))]
	[XmlInclude(typeof(StreetNameType))]
	[XmlInclude(typeof(ServiceNameType))]
	[XmlInclude(typeof(RoamingPartnerNameType))]
	[XmlInclude(typeof(RetailEventNameType))]
	[XmlInclude(typeof(RegistrationNameType))]
	[XmlInclude(typeof(OtherNameType))]
	[XmlInclude(typeof(NameType1))]
	[XmlInclude(typeof(ModelNameType))]
	[XmlInclude(typeof(MiddleNameType))]
	[XmlInclude(typeof(HolderNameType))]
	[XmlInclude(typeof(FirstNameType))]
	[XmlInclude(typeof(FileNameType))]
	[XmlInclude(typeof(FamilyNameType))]
	[XmlInclude(typeof(CitySubdivisionNameType))]
	[XmlInclude(typeof(CityNameType))]
	[XmlInclude(typeof(CategoryNameType))]
	[XmlInclude(typeof(BuildingNameType))]
	[XmlInclude(typeof(BrandNameType))]
	[XmlInclude(typeof(BlockNameType))]
	[XmlInclude(typeof(AliasNameType))]
	[XmlInclude(typeof(AdditionalStreetNameType))]
	[GeneratedCode("xsd", "4.6.1055.0")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
	[Serializable]
	public class NameType : TextType
	{
	}
}
