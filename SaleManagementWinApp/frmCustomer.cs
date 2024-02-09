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
    public partial class frmCustomer : Form
    {
        private ICustomerRepository customerRepository;

        public Boolean isAdd {  get; set; }

        public int generatedID { get; set; }
        public Customer Customer { get; set; }

        public frmCustomer()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Email is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Name is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtCity.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("City is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtCountry.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Country is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Password is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Customer? customer = new Customer()
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    Email = txtEmail.Text,
                    CustomerName = txtName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                    Birthday = dtpBirthday.Value,
                    CustomerStatus = cbIsActive.Checked ? (byte)1 : (byte)0
                };
                if (isAdd)
                {
                    customerRepository.AddCustomer(customer);
                }
                else
                {
                    customerRepository.UpdateCustomer(customer);
                }
                this.Close();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = generatedID.ToString();
            if (Customer != null)
            {
                txtCustomerID.Text = Customer.CustomerId.ToString();
                txtEmail.Text = Customer.Email;
                txtName.Text = Customer.CustomerName;
                txtCity.Text = Customer.City;
                txtCountry.Text = Customer.Country;
                txtPassword.Text = Customer.Password;
                dtpBirthday.Value = (DateTime)Customer.Birthday;
                cbIsActive.Checked = Customer.CustomerStatus == 1 ? true : false;
            }
        }
    }
}
