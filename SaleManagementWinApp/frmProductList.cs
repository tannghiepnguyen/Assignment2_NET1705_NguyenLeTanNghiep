using BusinessObjects;
using DataAccessObjects;
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
    public partial class frmProductList : Form
    {
        private IProductRepository productRepository;
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository;

        public Customer? Customer { get; set; }
        public bool isAdmin { get; set; }
        public frmProductList()
        {
            orderRepository = new OrderRepository();
            productRepository = new ProductRepository();
            orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void LoadProductList()
        {
            dgvProductList.DataSource = productRepository.GetAllProduct().Select(c => new
            {
                c.FlowerBouquetId,
                c.CategoryId,
                c.FlowerBouquetName,
                c.Description,
                c.UnitPrice,
                c.UnitsInStock,
                c.FlowerBouquetStatus,
                c.SupplierId,
                c.Morphology
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            int lastIndex = dgvProductList.RowCount - 1;
            frmProduct frmProduct = new frmProduct()
            {
                Text = "New product",
                generatedID = (int)dgvProductList.Rows[lastIndex].Cells[0].Value + 1,
                isAdd = true,
            };
            frmProduct.ShowDialog();
            LoadProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvProductList.CurrentRow.Index;
            DataGridViewRow row = dgvProductList.Rows[currentIndex];
            frmProduct frmProduct = new frmProduct()
            {
                Text = "Update product",
                isAdd = false,
                Product = new FlowerBouquet()
                {
                    FlowerBouquetId = (int)row.Cells[0].Value,
                    CategoryId = (int)row.Cells[1].Value,
                    FlowerBouquetName = (string)row.Cells[2].Value,
                    Description = (string)row.Cells[3].Value,
                    UnitPrice = (decimal)row.Cells[4].Value,
                    UnitsInStock = (int)row.Cells[5].Value,
                    FlowerBouquetStatus = (byte?)row.Cells[6].Value,
                    SupplierId = (int?)(row.Cells[7].Value),
                    Morphology = (string?)row.Cells[8].Value,
                }
            };
            frmProduct.ShowDialog();
            LoadProductList();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                btnOrder.Visible = false;
            }
            else
            {
                btnNew.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            LoadProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvProductList.CurrentRow.Index;
            DataGridViewRow row = dgvProductList.Rows[currentIndex];
            FlowerBouquet product = new FlowerBouquet()
            {
                FlowerBouquetId = (int)row.Cells[0].Value
            };
            productRepository.DeleteProduct(product);
            LoadProductList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<OrderDetail> orderedItem = new List<OrderDetail>();
            int generatedID = orderRepository.GetMaximumOrderID() + 1;
            foreach (DataGridViewRow row in dgvProductList.SelectedRows)
            {
                orderedItem.Add(new OrderDetail()
                {
                    OrderId = generatedID,
                    FlowerBouquetId = (int)row.Cells[0].Value,
                    UnitPrice = (decimal)row.Cells[4].Value,
                    Quantity = 1,
                    Discount = 0
                });
            }
            frmCheckout frmCheckout = new frmCheckout()
            {
                Customer = Customer,
                orderItems = orderedItem,
            };
            frmCheckout.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbProductID.Checked)
            {
                if (txtSearch.Text.Equals(string.Empty)) { 
                    LoadProductList(); 
                }
                else
                {
                    dgvProductList.DataSource = productRepository.GetAllProduct().Where(c => c.FlowerBouquetId.ToString().Equals(txtSearch.Text)).Select(c => new
                    {
                        c.FlowerBouquetId,
                        c.CategoryId,
                        c.FlowerBouquetName,
                        c.Description,
                        c.UnitPrice,
                        c.UnitsInStock,
                        c.FlowerBouquetStatus,
                        c.SupplierId,
                        c.Morphology
                    }).ToList();
                }
            }
            else if (rbProductName.Checked)
            {
                dgvProductList.DataSource = productRepository.GetAllProduct().Where(c => c.FlowerBouquetName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).Select(c => new
                {
                    c.FlowerBouquetId,
                    c.CategoryId,
                    c.FlowerBouquetName,
                    c.Description,
                    c.UnitPrice,
                    c.UnitsInStock,
                    c.FlowerBouquetStatus,
                    c.SupplierId,
                    c.Morphology
                }).ToList();
            }
        }
    }
}
