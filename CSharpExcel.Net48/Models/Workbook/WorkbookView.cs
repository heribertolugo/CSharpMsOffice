using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "workbookView", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class WorkbookView
	{
		public WorkbookView()
        {
			this.XWindow = -21495;
			this.YWindow = 1800;
			this.WindowWidth = 18000;
			this.WindowHeight = 9360;
			this.Uid = "{9A79C0AD-48D2-453F-A8E8-A4D350885F94}";
		}
		[XmlAttribute(AttributeName = "xWindow", Namespace = "")]
		public int XWindow { get; set; }

		[XmlAttribute(AttributeName = "yWindow", Namespace = "")]
		public int YWindow { get; set; }

		[XmlAttribute(AttributeName = "windowWidth", Namespace = "")]
		public int WindowWidth { get; set; }

		[XmlAttribute(AttributeName = "windowHeight", Namespace = "")]
		public int WindowHeight { get; set; }

		[XmlAttribute(AttributeName = "uid", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2015/revision2")]
		public string Uid { get; set; }
	}


}
