using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "bookViews", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class BookViews
	{

		[XmlElement(ElementName = "workbookView", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public WorkbookView WorkbookView { get; set; }
	}


}
