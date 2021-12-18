using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "sheets", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Sheets
	{

		[XmlElement(ElementName = "sheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public Sheet Sheet { get; set; }
	}


}
