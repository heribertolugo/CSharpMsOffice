using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Workbook));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Workbook)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "fileVersion", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class FileVersion
	{
		public FileVersion()
        {
			this.AppName = "xl";
			this.LastEdited = 7;
			this.LowestEdited = 7;
			this.RupBuild = 24131;
        }
		[XmlAttribute(AttributeName = "appName", Namespace = "")]
		public string AppName { get; set; }

		[XmlAttribute(AttributeName = "lastEdited", Namespace = "")]
		public int LastEdited { get; set; }

		[XmlAttribute(AttributeName = "lowestEdited", Namespace = "")]
		public int LowestEdited { get; set; }

		[XmlAttribute(AttributeName = "rupBuild", Namespace = "")]
		public int RupBuild { get; set; }
	}


}
