using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "definedNames", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class DefinedNames
	{

		[XmlElement(ElementName = "definedName", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public DefinedName DefinedName { get; set; }
	}


}
