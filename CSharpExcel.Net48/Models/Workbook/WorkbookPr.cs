using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "workbookPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class WorkbookPr
	{
		public WorkbookPr() { }
		public WorkbookPr(bool setDefaultThemeVersion, bool setChartTrackingRefBase)
        {
			if (setDefaultThemeVersion)
				this.DefaultThemeVersion = 166925;
			if (setChartTrackingRefBase)
				this.ChartTrackingRefBase = 1;
		}
		[XmlAttribute(AttributeName = "defaultThemeVersion", Namespace = "")]
		public int DefaultThemeVersion { get; set; }
		/// <summary>
		/// Not sure what this is
		/// </summary>
		[XmlAttribute(AttributeName = "chartTrackingRefBase", Namespace = "")]
		public int ChartTrackingRefBase { get; set; }
	}


}
