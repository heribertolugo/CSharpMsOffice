using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "sheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Sheet
	{

		[XmlAttribute(AttributeName = "name", Namespace = "")]
		public string Name { get; set; }
		/// <summary>
		/// Sheet ID, usually the order in the collection of sheets
		/// </summary>
		[XmlAttribute(AttributeName = "sheetId", Namespace = "")]
		public int SheetId { get; set; }
		/// <summary>
		/// Defines the relationship ID
		/// </summary>
		[XmlAttribute(AttributeName = "id", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string Id { get; set; }
	}


}
