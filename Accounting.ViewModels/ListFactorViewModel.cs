using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModels
{
    public class ListFactorViewModel
    {
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public DateTime FactorDate { get; set; }
        public int QTY { get; set; }
        public int Price { get; set; }
        public int TotalAmount { get; set; }
    }
}
