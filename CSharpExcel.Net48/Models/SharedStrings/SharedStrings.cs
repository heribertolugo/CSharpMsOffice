using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpExcel.Net48
{

    [XmlRoot(ElementName = "sst", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class SharedStrings
	{
		public SharedStrings()
        {
			this.Xmlns = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        }

		[XmlElement(ElementName = "si", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<StringValue> StringValues { get; set; }

		[XmlAttribute(AttributeName = "xmlns", Namespace = "")]
		public string Xmlns { get; set; }

		/// <summary>
		/// The number of shared strings in the collection
		/// </summary>
		[XmlAttribute(AttributeName = "count", Namespace = "")]
		public int Count { get; set; } // TODO: have this return StringValues count, do nothing when set? or set StringValues count?

		/// <summary>
		/// The number of unique shared strings in the collection
		/// </summary>
		[XmlAttribute(AttributeName = "uniqueCount", Namespace = "")]
		public int UniqueCount { get; set; } // TODO: have this return StringValues unique count, do nothing when set? or set StringValues count?

		/// <summary>
		/// Not sure what this is for
		/// </summary>
		[XmlText]
		public string Text { get; set; }
	}
}
