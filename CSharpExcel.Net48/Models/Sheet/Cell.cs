using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    /// <summary>
    /// Represents a Cell
    /// </summary>
    [XmlRoot(ElementName = "c", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Cell
	{
		/// <summary>
		/// Represents a Value in a cell
		/// </summary>
		[XmlElement(ElementName = "v", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public int Value { get; set; }

		/// <summary>
		/// The cells Range Address
		/// </summary>
		[XmlAttribute(AttributeName = "r", Namespace = "")]
		public string Address { get; set; }

		/// <summary>
		/// Represents the index of the Style used.
		/// </summary>
		[XmlAttribute(AttributeName = "s", Namespace = "")]
		public int Style { get; set; }

		/// <summary>
		/// Used if cells value is a string from SharedStrings, with value of s. In which case the cell must have V which is index in SharedStrings.
		/// </summary>
		[XmlAttribute(AttributeName = "t", Namespace = "")]
		public string T { get; set; }

		/// <summary>
		/// Not used
		/// </summary>
		[XmlText]
		public int Text { get; set; }

		/// <summary>
		/// Represents a Excel Function
		/// </summary>
		[XmlElement(ElementName = "f", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public string Function { get; set; }
	}
}
