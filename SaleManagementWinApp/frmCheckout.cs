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
    public partial class frmCheckout : Form
    {
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;
        public Customer? Customer { get; set; }
        public List<OrderDetail> orderItems { get; set; }
        public frmCheckout()
        {
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void LoadCheckoutList()
        {
            dgvProductListCheckOut.DataSource = orderItems.Select(c => new
            {
                c.OrderId,
                c.FlowerBouquetId,
                c.UnitPrice,
                c.Quantity,
                c.Discount
            }).ToList();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            LoadCheckoutList();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<OrderDetail> orderedItems = new List<OrderDetail>();
            int generatedID = orderRepository.GetMaximumOrderID() + 1;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProductListCheckOut.Rows)
            {
                total += ((decimal)row.Cells[2].Value * (1 - decimal.Parse(row.Cells[4].Value.ToString()) / 100)) * (int)row.Cells[3].Value;
                orderedItems.Add(new OrderDetail()
                {
                    OrderId = (int)row.Cells[0].Value,
                    FlowerBouquetId = (int)row.Cells[1].Value,
                    UnitPrice = (decimal)row.Cells[2].Value,
                    Quantity = (int)row.Cells[3].Value,
                    Discount = (double)row.Cells[4].Value
                });
            }
            Order order = new Order()
            {
                OrderId = generatedID,
                CustomerId = Customer?.CustomerId,
                OrderDate = DateTime.Now,
                ShippedDate = DateTime.Now.AddMonths(1),
                Total = total,
                OrderStatus = "0"
            };
            orderRepository.InsertOrder(order);
            orderDetailRepository.InsertOrderDetail(orderedItems);
            MessageBox.Show("Order successfully", "Order Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnChangeAmount_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvProductListCheckOut.CurrentRow.Index;
            if (numericAmount.Value < 0)
            {
                MessageBox.Show("Amount number is invalid", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (numericAmount.Value == 0)
            {
                orderItems.RemoveAt(rowIndex);
            }
            else
            {
                orderItems[rowIndex].Quantity = (int)numericAmount.Value;
            }
            LoadCheckoutList();
        }

        private void dgvProductListCheckOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProductListCheckOut.CurrentCell.ColumnIndex;
            if (index == 3)
            {
                numericAmount.Enabled = true;
                btnChangeAmount.Enabled = true;
            }
            else
            {
                numericAmount.Enabled = false;
                btnChangeAmount.Enabled = false;
            }
        }
    }
}
