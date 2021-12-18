using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "si", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class StringValue
	{

		[XmlElement(ElementName = "t", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public string Value { get; set; }
	}
}
