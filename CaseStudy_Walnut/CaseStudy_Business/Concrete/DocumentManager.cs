using CaseStudy_Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        public Task CreateAsync(Document document)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Document document)
        {
            throw new NotImplementedException();
        }

        public Task<List<Document>> GetAllDocuments()
        {
            throw new NotImplementedException();
        }

        public Task<Document> GetByIdAsnc(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
