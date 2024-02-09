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
    public partial class frmCustomerList : Form
    {
        private ICustomerRepository customerRepository;
        public frmCustomerList()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
            LoadCustomerList();

        }

        private void LoadCustomerList()
        {
            dgvCustomerList.DataSource = customerRepository.GetAllCustomer().Select(c => new
            {
                c.CustomerId,
                c.Email,
                c.CustomerName,
                c.City,
                c.Country,
                c.Password,
                c.Birthday,
                c.CustomerStatus
            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            int lastIndex = dgvCustomerList.RowCount - 1;
            frmCustomer frmCustomer = new frmCustomer()
            {
                Text = "New customer",
                generatedID = (int)dgvCustomerList.Rows[lastIndex].Cells[0].Value + 1,
                isAdd = true,

            };
            frmCustomer.ShowDialog();
            LoadCustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvCustomerList.CurrentRow.Index;
            DataGridViewRow row = dgvCustomerList.Rows[currentIndex];
            frmCustomer frmCustomer = new frmCustomer()
            {
                Text = "Update customer",
                isAdd = false,
                Customer = new Customer()
                {
                    CustomerId = (int)row.Cells[0].Value,
                    Email = (string)row.Cells[1].Value,
                    CustomerName = (string)row.Cells[2].Value,
                    City = (string)row.Cells[3].Value,
                    Country = (string)row.Cells[4].Value,
                    Password = (string)row.Cells[5].Value,
                    Birthday = (DateTime)row.Cells[6].Value,
                    CustomerStatus = (byte)row.Cells[7].Value,
                }
            };

            frmCustomer.ShowDialog();
            LoadCustomerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvCustomerList.CurrentRow.Index;
            DataGridViewRow row = dgvCustomerList.Rows[currentIndex];
            Customer customer = new Customer()
            {
                CustomerId = (int)row.Cells[0].Value,
            };
            customerRepository.DeleteCustomer(customer);
            LoadCustomerList();
        }
    }
}
