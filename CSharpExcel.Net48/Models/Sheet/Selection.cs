using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    /// <summary>
    /// Represents a cell or range which is actively selected
    /// </summary>
    [XmlRoot(ElementName = "selection", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Selection
	{
		private string defaultValue = "E7";
		public Selection()
		{
			this.ActiveCell = this.defaultValue;
			this.Sqref = this.defaultValue;
		}
		[XmlAttribute(AttributeName = "activeCell", Namespace = "")]
		public string ActiveCell { get; set; }

		[XmlAttribute(AttributeName = "sqref", Namespace = "")]
		public string Sqref { get; set; }
	}
}
