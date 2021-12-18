using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "row", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Row
	{

		[XmlElement(ElementName = "c", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<Cell> Cells { get; set; }

		/// <summary>
		/// The Row number (not index)
		/// </summary>
		[XmlAttribute(AttributeName = "r", Namespace = "")]
		public int RowNumber { get; set; }

		/// <summary>
		/// Not sure, but seems to have ratio? value. 1:2
		/// </summary>
		[XmlAttribute(AttributeName = "spans", Namespace = "")]
		public DateTime Spans { get; set; }

		/// <summary>
		/// Height of Row
		/// </summary>
		[XmlAttribute(AttributeName = "dyDescent", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac")]
		public double DyDescent { get; set; }

		/// <summary>
		/// Not used
		/// </summary>
		[XmlText]
		public int Text { get; set; }
	}
}
