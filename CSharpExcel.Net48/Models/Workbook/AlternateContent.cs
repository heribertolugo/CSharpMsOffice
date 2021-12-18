using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "AlternateContent", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
	public class AlternateContent
	{
		public AlternateContent()
        {
			this.Mc = "http://schemas.openxmlformats.org/markup-compatibility/2006";
        }
		[XmlElement(ElementName = "Choice", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
		public Choice Choice { get; set; }

		[XmlAttribute(AttributeName = "mc", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Mc { get; set; }
	}


}
