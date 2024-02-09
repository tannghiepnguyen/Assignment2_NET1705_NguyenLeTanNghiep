using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        #region
        private static OrderDetailDAO? instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<OrderDetail> GetOrderDetailByOrderID(int OrderID)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    List<OrderDetail> orderDetailList = context.OrderDetails.Where(c => c.OrderId == OrderID).ToList();
                    return orderDetailList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrderDetail(int OrderID)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {

                    var deleteOrderDetail = context.OrderDetails.Where(c => c.OrderId == OrderID);
                    context.OrderDetails.RemoveRange(deleteOrderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void InsertOrderDetail(List<OrderDetail> orderDetailList)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.OrderDetails.AddRange(orderDetailList);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
