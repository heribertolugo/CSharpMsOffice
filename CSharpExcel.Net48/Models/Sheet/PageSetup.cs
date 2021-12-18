using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "pageSetup", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class PageSetup
	{
		public PageSetup()
		{
			this.Orientation = "portrait";
			this.Id = "rId1";
		}
		[XmlAttribute(AttributeName = "orientation", Namespace = "")]
		public string Orientation { get; set; }

		[XmlAttribute(AttributeName = "id", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string Id { get; set; }
	}
}
