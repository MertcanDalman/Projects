using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace CaseStudy_Data.Concrete.Context
{
    public class CaseStudyContext
    {
        public class DataContext : IDisposable
        {
            private readonly IDataLayer _dataLayer;

            public DataContext(string connectionString)
            {
                _dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            }

            public UnitOfWork CreateUnitOfWork()
            {
                return new UnitOfWork(_dataLayer);
            }

            public void Dispose()
            {
                _dataLayer?.Dispose();
            }
        }
    }
}

