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

        private ProductRepositories _ProductRepositories;

        private GenericRepository<Factors> _FactorRepository;

        private GenericRepository<Accounting> _accountingrepository;

        private GenericRepository<Login> _loginrepository;

        private GenericRepository<Product> _productrepository;

        public GenericRepository<Factors> FactorRepository
        {
            get
            {
                if (_FactorRepository == null)
                {
                    _FactorRepository = new GenericRepository<Factors>(db);
                }
                return _FactorRepository;
            }

        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (_productrepository == null)
                {
                    _productrepository = new GenericRepository<Product>(db);
                }
                return _productrepository;
            }

        }

        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginrepository == null)
                {
                    _loginrepository = new GenericRepository<Login>(db);
                }
                return _loginrepository;
            }
        }

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

        public IProductRepository ProductRepositories
        {
            get
            {
                if (_ProductRepositories == null)
                {
                    _ProductRepositories = new ProductRepositories(db);
                }
                return _ProductRepositories;
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
