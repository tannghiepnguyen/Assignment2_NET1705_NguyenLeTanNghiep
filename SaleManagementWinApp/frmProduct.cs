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

        private void frmProduct_Load(object sender, EventArgs e)
        {
            cbCategoryID.DataSource = categoryRepository.GetAllCategories().ToList();
            cbCategoryID.ValueMember = "CategoryID";
            cbCategoryID.DisplayMember = "CategoryID";
            cbSupplierID.DataSource = supplierRepository.GetAllSupplier().ToList();
            cbSupplierID.ValueMember = "SupplierID";
            cbSupplierID.DisplayMember = "SupplierID";

            txtProductID.Text = generatedID.ToString();
            if (Product != null)
            {
                txtProductID.Text = Product.FlowerBouquetId.ToString();
                cbCategoryID.Text = Product.CategoryId.ToString();
                txtName.Text = Product.FlowerBouquetName.ToString();
                cbSupplierID.Text = Product.SupplierId.ToString();
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
            else
            {
                FlowerBouquet product = new FlowerBouquet()
                {
                    FlowerBouquetId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(cbCategoryID.Text),
                    FlowerBouquetName = txtName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = (int)numUnitInStock.Value,
                    FlowerBouquetStatus = cbIsActive.Checked ? (byte?)1 : (byte?)0,
                    SupplierId = int.Parse(cbSupplierID.Text),
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
