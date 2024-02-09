using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer) => CustomerDAO.Instance.InsertCustomer(customer);

        public void DeleteCustomer(Customer customer) => CustomerDAO.Instance.DeleteCustomer(customer);

        public (string, string) GetAdminAccount() => CustomerDAO.Instance.GetAdminAccount();

        public List<Customer> GetAllCustomer() => CustomerDAO.Instance.GetAllCustomer();

        public Customer? GetCustomerByEmailPassword(string email, string password) => CustomerDAO.Instance.GetCustomerByEmailPassword(email, password);

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);

       
    }
}
