using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "pageMargins", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class PageMargins
	{
		private double defaultSideMargin = 0.7;
		private double defaultMargin = 0.75;
		private double defaultHeaderFooter = 0.3;
		public PageMargins()
		{
			this.Left = this.defaultSideMargin;
			this.Right = this.defaultSideMargin;
			this.Top = this.defaultMargin;
			this.Bottom = this.defaultMargin;
			this.Footer = this.defaultHeaderFooter;
			this.Header = this.defaultHeaderFooter;
		}

		[XmlAttribute(AttributeName = "left", Namespace = "")]
		public double Left { get; set; }

		[XmlAttribute(AttributeName = "right", Namespace = "")]
		public double Right { get; set; }

		[XmlAttribute(AttributeName = "top", Namespace = "")]
		public double Top { get; set; }

		[XmlAttribute(AttributeName = "bottom", Namespace = "")]
		public double Bottom { get; set; }

		[XmlAttribute(AttributeName = "header", Namespace = "")]
		public double Header { get; set; }

		[XmlAttribute(AttributeName = "footer", Namespace = "")]
		public double Footer { get; set; }
	}
}
