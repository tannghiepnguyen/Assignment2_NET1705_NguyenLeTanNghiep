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
    public partial class frmLogin : Form
    {
        private ICustomerRepository customerRepository;
        public frmLogin()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer? customer = customerRepository.GetCustomerByEmailPassword(txtEmail.Text, txtPassword.Text);
            (string, string) adminAccount = customerRepository.GetAdminAccount();
            if (customer != null)
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = customer,
                    isAdmin = false
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else if (txtEmail.Text.Equals(adminAccount.Item1) && txtPassword.Text.Equals(adminAccount.Item2))
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = null,
                    isAdmin = true
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Email or password is incorrect", "Cannot log in", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}
