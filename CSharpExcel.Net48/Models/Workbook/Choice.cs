using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "Choice", Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
	public class Choice
	{
		public Choice()
        {
			this.Requires = "x15";
        }
		[XmlElement(ElementName = "absPath", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac")]
		public AbsPath AbsPath { get; set; }

		[XmlAttribute(AttributeName = "Requires", Namespace = "")]
		public string Requires { get; set; }
	}


}
