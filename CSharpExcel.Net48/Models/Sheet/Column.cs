using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "col", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Column
	{
		public Column()
		{
			this.BestFit = 1;
			this.CustomWidth = 1;
		}
		[XmlAttribute(AttributeName = "min", Namespace = "")]
		public int Min { get; set; }

		[XmlAttribute(AttributeName = "max", Namespace = "")]
		public int Max { get; set; }

		[XmlAttribute(AttributeName = "width", Namespace = "")]
		public double Width { get; set; }

		[XmlAttribute(AttributeName = "style", Namespace = "")]
		public int Style { get; set; }

		[XmlAttribute(AttributeName = "bestFit", Namespace = "")]
		public int BestFit { get; set; }

		[XmlAttribute(AttributeName = "customWidth", Namespace = "")]
		public int CustomWidth { get; set; }
	}
}
