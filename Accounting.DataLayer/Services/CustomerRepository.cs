using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities contex)
        {
            db = contex;
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }


        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }



        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool UpdateCustomer(Customers customer)
        {
            
            var local = db.Set<Customers>()
                 .Local
                 .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
           
        }



        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }



        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);  // estefade az method =>  GetCustomerById(int customerId)
                DeleteCustomer(customer);   // estefade az method => DeleteCustomer(Customers customer)
                return true;
            }
            catch
            {
                return false;
            }

        }




        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) ||
                                             c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetCustomersName(string Filter = "")
        {
            if (Filter == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }

            return db.Customers.Where(c => c.FullName.Contains(Filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName
            }).ToList();


        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }
    }
}
