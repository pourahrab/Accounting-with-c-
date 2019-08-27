using Accounting.DataLayer.Repositories;
using Accounting.ViewModels;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    class ProductRepositories : IProductRepository
    {
        private Accounting_DBEntities db;

        public ProductRepositories(Accounting_DBEntities contex)
        {
            db = contex;
        }
        public List<ListProductViewModel> GetProductName(string filter = "")
        {

            if (filter == "")
            {
                return db.Product.Select(p => new ListProductViewModel()
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName
                }).ToList();
            }
            return db.Product.Where(p => p.ProductName.Contains(filter)).Select (p=> new ListProductViewModel()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName
            }).ToList();
        }

       
        }
    }
}
