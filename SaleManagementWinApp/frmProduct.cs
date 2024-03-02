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
    public partial class frmProduct : Form
    {
        private ICategoryRepository categoryRepository;
        private ISupplierRepository supplierRepository;
        private IProductRepository productRepository;   

        public int generatedID { get; set; }
        public bool isAdd { get; set; }
        public FlowerBouquet Product { get; set; }
        public frmProduct()
        {
            productRepository = new ProductRepository();
            categoryRepository = new CategoryRepository();
            supplierRepository = new SupplierRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

		private bool IsNumeric(string input)
		{
			double test;
			return double.TryParse(input, out test);
		}

		private void frmProduct_Load(object sender, EventArgs e)
        {
            cbCategoryID.DataSource = categoryRepository.GetAllCategories().ToList();
            cbCategoryID.ValueMember = "CategoryID";
            cbCategoryID.DisplayMember = "CategoryName";
            cbSupplierID.DataSource = supplierRepository.GetAllSupplier().ToList();
            cbSupplierID.ValueMember = "SupplierID";
            cbSupplierID.DisplayMember = "SupplierName";

            txtProductID.Text = generatedID.ToString();
            if (Product != null)
            {
                txtProductID.Text = Product.FlowerBouquetId.ToString();
                cbCategoryID.Text = categoryRepository.GetNameById(Product.CategoryId);
                txtName.Text = Product.FlowerBouquetName.ToString();
                cbSupplierID.Text = supplierRepository.GetNameById(Product.SupplierId);
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                numUnitInStock.Value = Product.UnitsInStock;
                cbIsActive.Checked = Product.FlowerBouquetStatus == 1; 
                txtDescription.Text = Product.Description.ToString();
                txtMorphology.Text = Product.Morphology?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Name is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtDescription.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Description is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtUnitPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Unit price is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtMorphology.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Morphology is empty", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!IsNumeric(txtUnitPrice.Text))
            {
				MessageBox.Show("Unit price is not a number", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else if (decimal.Parse(txtUnitPrice.Text) <= 0)
            {
				MessageBox.Show("Unit price must be positive", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
			else if (numUnitInStock.Value <= 0)
            {
				MessageBox.Show("Unit in stock must be positive", "Invalid input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}
            else
            {
                FlowerBouquet product = new FlowerBouquet()
                {
                    FlowerBouquetId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(cbCategoryID.SelectedValue.ToString()),
                    FlowerBouquetName = txtName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = (int)numUnitInStock.Value,
                    FlowerBouquetStatus = cbIsActive.Checked ? (byte?)1 : (byte?)0,
                    SupplierId = int.Parse(cbSupplierID.SelectedValue.ToString()),
                    Morphology = (string?)txtMorphology.Text,
                };
                if (isAdd)
                {
                    productRepository.AddProduct(product);
                }
                else
                {
                    productRepository.UpdateProduct(product);
                }
                this.Close();
            }
        }
    }
}
