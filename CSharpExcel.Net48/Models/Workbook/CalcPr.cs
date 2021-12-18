using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "calcPr", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class CalcPr
	{
		public CalcPr()
        {
			this.CalcId = 191029;

		}
		[XmlAttribute(AttributeName = "calcId", Namespace = "")]
		public int CalcId { get; set; }
	}


}
