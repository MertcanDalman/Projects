using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsnc(int id);
        Task<List<TEntity>> GetAllDocuments();
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
