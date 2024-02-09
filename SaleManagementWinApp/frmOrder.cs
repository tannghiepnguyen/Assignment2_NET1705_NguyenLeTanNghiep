using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmOrder : Form
    {
        private IOrderRepository orderRepository;
        public Order Order { get; set; }
        public frmOrder()
        {
            orderRepository = new OrderRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtOrderID.Text = Order.OrderId.ToString();
            txtCustomerID.Text = Order.CustomerId.ToString();
            dtpOrderDate.Value = Order.OrderDate;
            dtpShippedDate.Value = (DateTime)Order.ShippedDate;
            txtTotal.Text = Order.Total.ToString();
            cbOrderStatus.Checked = Order.OrderStatus.Trim().Equals("1");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                OrderId = int.Parse(txtOrderID.Text),
                CustomerId = int.Parse(txtCustomerID.Text),
                OrderDate = dtpOrderDate.Value,
                ShippedDate = dtpShippedDate.Value,
                Total = decimal.Parse(txtTotal.Text),
                OrderStatus = cbOrderStatus.Checked ? "1" : "0",
            };
            orderRepository.UpdateOrder(order);
            this.Close();
        }
    }
}
