using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        #region
        private static CustomerDAO? instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<Customer> GetAllCustomer()
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    List<Customer> customerList = context.Customers.ToList();
                    return customerList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void InsertCustomer(Customer customer)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Entry<Customer>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void DeleteCustomer(Customer customer)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    
                    var deleteCustomer = context.Customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
                    context.Customers.Remove(deleteCustomer);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Customer? GetCustomerByEmailPassword(string email, string password)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    Customer? customer = context.Customers.SingleOrDefault(c => c.Email.Equals(email) && c.Password.Equals(password));
                    return customer;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public (string, string) GetAdminAccount()
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    return context.GetAdminAccount();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
