using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{
    [XmlRoot(ElementName = "cols", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class Cols
	{
		public Cols()
		{
			this.Columns = new List<Column>();
		}
		[XmlElement(ElementName = "col", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<Column> Columns { get; set; }
		public Column AddColumn()
		{
			int minMax = this.Columns.Count + 1;
			Column column = new Column() { Min = minMax, Max = minMax, Width = 13 };
			this.Columns.Add(column);
			return column;
		}
	}
}
