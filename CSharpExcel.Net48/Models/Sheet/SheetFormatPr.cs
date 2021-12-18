using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "sheetFormatPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class SheetFormatPr
	{
		public SheetFormatPr()
		{
			this.DefaultRowHeight = 15;
			this.DyDescent = 0.25;
		}
		[XmlAttribute(AttributeName = "defaultRowHeight", Namespace = "")]
		public int DefaultRowHeight { get; set; }

		[XmlAttribute(AttributeName = "dyDescent", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac")]
		public double DyDescent { get; set; }
	}
}
