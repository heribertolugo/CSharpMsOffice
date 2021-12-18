using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "ext", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Ext
	{
		public Ext()
        {
			this.Uri = "{140A7094-0E35-4892-8432-C4D2E57EDEB5}";
			this.X15 = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main";
			this.WorkbookPr = new WorkbookPr(setChartTrackingRefBase: true, setDefaultThemeVersion: false);
        }
		[XmlElement(ElementName = "workbookPr", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main")]
		public WorkbookPr WorkbookPr { get; set; }

		[XmlAttribute(AttributeName = "uri", Namespace = "")]
		public string Uri { get; set; }

		[XmlAttribute(AttributeName = "x15", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string X15 { get; set; }
	}


}
