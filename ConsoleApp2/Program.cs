using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Contex;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitofWork db = new UnitofWork();

            var list = db.CustomerRepository.GetAllCustomers();

            db.Dispose();

        }
    }
}
