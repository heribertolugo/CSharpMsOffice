using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "sheetView", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class SheetView
	{
		public SheetView()
		{
			this.TabSelected = 1;
			this.WorkbookViewId = 0;
		}
		[XmlElement(ElementName = "selection", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public Selection Selection { get; set; }

		[XmlAttribute(AttributeName = "tabSelected", Namespace = "")]
		public int TabSelected { get; set; }

		[XmlAttribute(AttributeName = "workbookViewId", Namespace = "")]
		public int WorkbookViewId { get; set; }
	}
}
