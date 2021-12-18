using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Worksheet));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Worksheet)serializer.Deserialize(reader);
    // }

    /// <summary>
    /// Defines the area populated with data in form of a range
    /// </summary>
    [XmlRoot(ElementName = "dimension", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Dimension
	{
		/// <summary>
		/// Defines the area populated with data in form of a range
		/// </summary>
		[XmlAttribute(AttributeName = "ref", Namespace = "")]
		public string RefRange { get; set; }
	}
}
