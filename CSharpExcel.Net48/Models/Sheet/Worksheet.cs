using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{

    [XmlRoot(ElementName = "worksheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Worksheet
	{

		[XmlElement(ElementName = "dimension", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public Dimension Dimension { get; set; }

		[XmlElement(ElementName = "sheetViews", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public SheetViews SheetViews { get; set; }

		[XmlElement(ElementName = "sheetFormatPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public SheetFormatPr SheetFormatPr { get; set; }

		[XmlElement(ElementName = "cols", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public Cols Cols { get; set; }

		[XmlElement(ElementName = "sheetData", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public SheetData SheetData { get; set; }

		[XmlElement(ElementName = "autoFilter", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public AutoFilter AutoFilter { get; set; }

		[XmlElement(ElementName = "pageMargins", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public PageMargins PageMargins { get; set; }

		[XmlElement(ElementName = "pageSetup", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public PageSetup PageSetup { get; set; }

		[XmlAttribute(AttributeName = "xmlns", Namespace = "")]
		public string Xmlns { get; set; }
		//The URL for relationships schema
		[XmlAttribute(AttributeName = "r", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string R { get; set; }

		[XmlAttribute(AttributeName = "mc", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Mc { get; set; }

		[XmlAttribute(AttributeName = "Ignorable", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
		public string Ignorable { get; set; }

		[XmlAttribute(AttributeName = "x14ac", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string X14ac { get; set; }

		[XmlAttribute(AttributeName = "xr", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr { get; set; }

		[XmlAttribute(AttributeName = "xr2", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr2 { get; set; }

		[XmlAttribute(AttributeName = "xr3", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr3 { get; set; }

		[XmlAttribute(AttributeName = "uid", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision")]
		public string Uid { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
