using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "extLst", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class ExtLst
	{
		public ExtLst()
        {
			this.Ext = new List<Ext>();
        }
		[XmlElement(ElementName = "ext", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
		public List<Ext> Ext { get; set; }
	}


}
