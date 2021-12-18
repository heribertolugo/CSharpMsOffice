using System.Xml.Serialization;

namespace CSharpExcel.Net48.Models.Workbook
{
    [XmlRoot(ElementName = "revisionPtr", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision")]
	public class RevisionPtr
	{
		public RevisionPtr()
        {
			this.RevIDLastSave = 0;
			this.DocumentId = "8_{4AD2CA98-DB5F-4CB4-A60A-E435A5700B1C}";
			this.CoauthVersionLast = 47;
			this.CoauthVersionMax = 47;
			this.UidLastSave = "{00000000-0000-0000-0000-000000000000}";
        }
		[XmlAttribute(AttributeName = "revIDLastSave", Namespace = "")]
		public int RevIDLastSave { get; set; }

		[XmlAttribute(AttributeName = "documentId", Namespace = "")]
		public string DocumentId { get; set; }

		[XmlAttribute(AttributeName = "coauthVersionLast", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2016/revision6")]
		public int CoauthVersionLast { get; set; }

		[XmlAttribute(AttributeName = "coauthVersionMax", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2016/revision6")]
		public int CoauthVersionMax { get; set; }

		[XmlAttribute(AttributeName = "uidLastSave", Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2016/revision10")]
		public string UidLastSave { get; set; }
	}


}
