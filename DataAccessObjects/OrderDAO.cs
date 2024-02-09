using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        #region
        private static OrderDAO? instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<Order> GetAllOrder()
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    List<Order> orderList = context.Orders.ToList();
                    return orderList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertOrder(Order order)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {

                    var deleteOrder = context.Orders.SingleOrDefault(c => c.OrderId == order.OrderId);
                    OrderDetailDAO.Instance.DeleteOrderDetail(order.OrderId);
                    context.Orders.Remove(deleteOrder);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetMaximumOrderID()
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    
                    int generatedID = context.Orders.Max(c => c.OrderId);
                    return generatedID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
