using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "definedName", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	public class DefinedName
	{
		public DefinedName()
        {
			this.Name = "_xlnm._FilterDatabase";
			this.LocalSheetId = 0;
			this.Hidden = 1;
			this.Text = "Sheet1!$A$1:$A$3";
		}
		[XmlAttribute(AttributeName = "name", Namespace = "")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "localSheetId", Namespace = "")]
		public int LocalSheetId { get; set; }

		[XmlAttribute(AttributeName = "hidden", Namespace = "")]
		public int Hidden { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


}
