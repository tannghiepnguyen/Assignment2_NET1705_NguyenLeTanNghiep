using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomer();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer? GetCustomerByEmailPassword(string email, string password);
        (string, string) GetAdminAccount();
        int GetIdByName(string name);
        string GetNameById(int id);
    }
}
