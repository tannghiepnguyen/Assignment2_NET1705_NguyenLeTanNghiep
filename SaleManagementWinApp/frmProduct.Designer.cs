namespace SaleManagementWinApp
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCategoryID = new Label();
            lbName = new Label();
            txtName = new TextBox();
            lbDescription = new Label();
            txtDescription = new TextBox();
            lbUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lbUnitInStock = new Label();
            lbStatus = new Label();
            txtMorphology = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            cbIsActive = new CheckBox();
            lbMorphology = new Label();
            lbSupplierID = new Label();
            lbProductID = new Label();
            txtProductID = new TextBox();
            cbCategoryID = new ComboBox();
            cbSupplierID = new ComboBox();
            numUnitInStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUnitInStock).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(38, 87);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(76, 134);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(132, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 27);
            txtName.TabIndex = 1;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(37, 418);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 0;
            lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 415);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(271, 162);
            txtDescription.TabIndex = 1;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(50, 229);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 0;
            lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(132, 226);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(271, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(31, 280);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(92, 20);
            lbUnitInStock.TabIndex = 0;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(76, 330);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Status";
            // 
            // txtMorphology
            // 
            txtMorphology.Location = new Point(132, 369);
            txtMorphology.Name = "txtMorphology";
            txtMorphology.Size = new Size(271, 27);
            txtMorphology.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(131, 608);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(309, 608);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(132, 330);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(72, 24);
            cbIsActive.TabIndex = 4;
            cbIsActive.Text = "Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lbMorphology
            // 
            lbMorphology.AutoSize = true;
            lbMorphology.Location = new Point(31, 372);
            lbMorphology.Name = "lbMorphology";
            lbMorphology.Size = new Size(91, 20);
            lbMorphology.TabIndex = 5;
            lbMorphology.Text = "Morphology";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Location = new Point(43, 183);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new Size(83, 20);
            lbSupplierID.TabIndex = 0;
            lbSupplierID.Text = "Supplier ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(46, 45);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(131, 42);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(271, 27);
            txtProductID.TabIndex = 1;
            // 
            // cbCategoryID
            // 
            cbCategoryID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryID.FormattingEnabled = true;
            cbCategoryID.Location = new Point(134, 89);
            cbCategoryID.Name = "cbCategoryID";
            cbCategoryID.Size = new Size(269, 28);
            cbCategoryID.TabIndex = 6;
            // 
            // cbSupplierID
            // 
            cbSupplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplierID.FormattingEnabled = true;
            cbSupplierID.Location = new Point(132, 180);
            cbSupplierID.Name = "cbSupplierID";
            cbSupplierID.Size = new Size(269, 28);
            cbSupplierID.TabIndex = 6;
            // 
            // numUnitInStock
            // 
            numUnitInStock.Location = new Point(132, 278);
            numUnitInStock.Name = "numUnitInStock";
            numUnitInStock.Size = new Size(269, 27);
            numUnitInStock.TabIndex = 7;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 666);
            Controls.Add(numUnitInStock);
            Controls.Add(cbSupplierID);
            Controls.Add(cbCategoryID);
            Controls.Add(lbMorphology);
            Controls.Add(cbIsActive);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtMorphology);
            Controls.Add(lbStatus);
            Controls.Add(lbUnitInStock);
            Controls.Add(lbSupplierID);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(lbDescription);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Controls.Add(lbCategoryID);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbName;
        private TextBox txtName;
        private Label lbDescription;
        private TextBox txtDescription;
        private Label lbUnitPrice;
        private TextBox txtUnitPrice;
        private Label lbUnitInStock;
        private Label lbStatus;
        private TextBox txtMorphology;
        private Button btnAdd;
        private Button btnClose;
        private CheckBox cbIsActive;
        private Label lbMorphology;
        private Label lbSupplierID;
        private Label lbProductID;
        private TextBox txtProductID;
        private ComboBox cbCategoryID;
        private ComboBox cbSupplierID;
        private NumericUpDown numUnitInStock;
    }
}