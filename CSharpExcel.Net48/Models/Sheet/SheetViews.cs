using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "sheetViews", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class SheetViews
	{
		public SheetViews()
		{
			this.SheetView = new List<SheetView>() { new SheetView() };
		}
		[XmlElement(ElementName = "sheetView", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<SheetView> SheetView { get; set; }
	}
}
