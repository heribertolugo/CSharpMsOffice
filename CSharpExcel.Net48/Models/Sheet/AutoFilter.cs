using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "autoFilter", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class AutoFilter
	{
		public AutoFilter()
		{
			this.Uid = "{8DCB16A4-1F85-4B2B-9C90-81CBA33DF401}";
		}
		/// <summary>
		/// The Range of the columns using Auto Filter (A1:A3)
		/// </summary>
		[XmlAttribute(AttributeName = "ref", Namespace = "")]
		public string RefRange { get; set; }
		/// <summary>
		/// This might need to be hard-coded value of {8DCB16A4-1F85-4B2B-9C90-81CBA33DF401}
		/// </summary>
		[XmlAttribute(AttributeName = "uid", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision")]
		public string Uid { get; set; }
	}
}
