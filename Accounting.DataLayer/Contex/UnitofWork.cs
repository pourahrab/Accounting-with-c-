using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Contex
{
    public class UnitofWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _CustomerRepository;

        private GenericRepository<Accounting> _accountingrepository;

        public GenericRepository<Accounting> accountingrepository
        {
            get
            {

                if (_accountingrepository == null)
                {
                    _accountingrepository = new GenericRepository<Accounting>(db);
                }
                return _accountingrepository;

            }

        }
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository(db);
                }
                return _CustomerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
