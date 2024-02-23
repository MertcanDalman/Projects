using DevExpress.Xpo;

namespace CaseStudy.Models
{
    [Persistent("LicenseTable")]
    public class License : XPObject
    {
        public License(Session session) : base(session) { }

        public string Key { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
