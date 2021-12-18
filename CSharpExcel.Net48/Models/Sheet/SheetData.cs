using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "sheetData", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class SheetData
	{

		[XmlElement(ElementName = "row", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<Row> Row { get; set; }
	}
}
