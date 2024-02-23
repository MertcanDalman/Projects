using DevExpress.Xpo;

namespace CaseStudy.Models
{
    public class Document : XPObject
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string PageCount { get; set; }
        public string FilePath { get; set; }

    }
}
