using BusinessObjects;
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
    public partial class frmMain : Form
    {
        public Customer? Customer { get; set; }
        public bool isAdmin { get; set; } = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogout_Click(object sender, EventArgs e) => this.Close();

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerList frmCustomerList = new frmCustomerList();
            this.Hide();
            frmCustomerList.ShowDialog();
            this.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductList frmProductList = new frmProductList()
            {
                Customer = Customer,
                isAdmin = isAdmin
            };
            this.Hide();
            frmProductList.ShowDialog();
            this.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                Customer = Customer
            };
            this.Hide();
            frmProfile.ShowDialog();
            this.Visible = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderList frmOrderList = new frmOrderList()
            {
                Customer = Customer,
                isAdmin = isAdmin
            };
            this.Hide();
            frmOrderList.ShowDialog();
            this.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                btnProfile.Hide();
            }
            else
            {
                pnlForAdmin.Hide();
            }
        }
    }
}
