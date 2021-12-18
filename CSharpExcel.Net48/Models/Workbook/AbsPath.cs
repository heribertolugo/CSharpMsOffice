using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "absPath", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac")]
	public class AbsPath
	{
		public AbsPath()
        {
			this.X15ac = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac";
		}
		/// <summary>
		/// The local root path of the Workbook Document; Such as D:\work\folder1\
		/// </summary>
		[XmlAttribute(AttributeName = "url", Namespace = "")]
		public string Url { get; set; }

		[XmlAttribute(AttributeName = "x15ac", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string X15ac { get; set; }
	}


}
