using CaseStudy_Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Entity.Concrete
{
    public class Document : BaseEntity
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
