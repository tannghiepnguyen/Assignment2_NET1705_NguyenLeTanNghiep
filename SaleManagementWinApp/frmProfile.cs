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
using System.Xml.Linq;

namespace SaleManagementWinApp
{
    public partial class frmProfile : Form
    {
        private ICustomerRepository customerRepository;
        public Customer? Customer { get; set; }
        public frmProfile()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = Customer?.CustomerId.ToString();
            txtCustomerName.Text = Customer?.CustomerName.ToString();
            txtEmail.Text = Customer?.Email.ToString();
            txtCity.Text = Customer?.City.ToString();
            txtCountry.Text = Customer?.Country.ToString();
            dtpBirthday.Value = (DateTime)Customer?.Birthday;
            txtPassword.Text = Customer?.Password.ToString();
            txtConfirmPassword.Text = Customer?.Password.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and confirm password don't match", "Password not match", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Email is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtCustomerName.Text.Trim().Equals(string.Empty))
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
                Customer customer = new Customer()
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    Email = txtEmail.Text,
                    CustomerName = txtCustomerName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                    Birthday = dtpBirthday.Value,
                    CustomerStatus = Customer?.CustomerStatus
                };
                customerRepository.UpdateCustomer(customer);
                MessageBox.Show("Update profile successfully", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
