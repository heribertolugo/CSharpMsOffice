using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{

    [XmlRoot(ElementName = "workbook", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Workbook
	{
		public Workbook()
        {
			this.FileVersion = new FileVersion();
			this.WorkbookPr = new WorkbookPr(setDefaultThemeVersion: true, setChartTrackingRefBase: false);
			this.AlternateContent = new AlternateContent();
			this.RevisionPtr = new RevisionPtr();
			this.BookViews = new BookViews();
			this.BookViews.WorkbookView = new WorkbookView();
			this.ExtLst = new ExtLst();
		}
		[XmlElement(ElementName = "fileVersion", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public FileVersion FileVersion { get; set; }

		[XmlElement(ElementName = "workbookPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public WorkbookPr WorkbookPr { get; set; }

		[XmlElement(ElementName = "AlternateContent", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
		public AlternateContent AlternateContent { get; set; }

		[XmlElement(ElementName = "revisionPtr", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision")]
		public RevisionPtr RevisionPtr { get; set; }

		[XmlElement(ElementName = "bookViews", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public BookViews BookViews { get; set; }

		[XmlElement(ElementName = "sheets", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public Sheets Sheets { get; set; }

		[XmlElement(ElementName = "definedNames", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public DefinedNames DefinedNames { get; set; }

		[XmlElement(ElementName = "calcPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public CalcPr CalcPr { get; set; }

		//TODO: this class should be changed to List. XML output should match current setup
		[XmlElement(ElementName = "extLst", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public ExtLst ExtLst { get; set; }

		[XmlAttribute(AttributeName = "xmlns", Namespace = "")]
		public string Xmlns { get; set; }

		[XmlAttribute(AttributeName = "r", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string R { get; set; }

		[XmlAttribute(AttributeName = "mc", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Mc { get; set; }

		[XmlAttribute(AttributeName = "Ignorable", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
		public string Ignorable { get; set; }

		[XmlAttribute(AttributeName = "x15", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string X15 { get; set; }

		[XmlAttribute(AttributeName = "xr", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr { get; set; }

		[XmlAttribute(AttributeName = "xr6", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr6 { get; set; }

		[XmlAttribute(AttributeName = "xr10", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr10 { get; set; }

		[XmlAttribute(AttributeName = "xr2", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xr2 { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


}
