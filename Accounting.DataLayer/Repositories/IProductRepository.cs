using Accounting.ViewModels;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface IProductRepository
    {
        List<ListProductViewModel> GetProductName(string filter = "");

        
    }
}
