using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetailByOrderID(int orderID);
        void InsertOrderDetail(List<OrderDetail> orderDetailList);
    }
}
