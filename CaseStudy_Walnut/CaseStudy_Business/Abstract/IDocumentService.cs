using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Business.Abstract
{
    public interface IDocumentService
    {
        #region Generic
        Task<Document> GetByIdAsnc(int id);
        Task<List<Document>> GetAllDocuments();
        Task CreateAsync(Document document);
        void Update(Document document);
        Task DeleteAsync(Document document);   
        #endregion
    }
}
