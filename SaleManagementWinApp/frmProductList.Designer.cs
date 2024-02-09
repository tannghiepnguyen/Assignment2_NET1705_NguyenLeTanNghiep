namespace SaleManagementWinApp
{
    partial class frmProductList
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
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnOrder = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            rbProductName = new RadioButton();
            rbProductID = new RadioButton();
            txtSearch = new TextBox();
            lbSearch = new Label();
            panel3 = new Panel();
            dgvProductList = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(497, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 38);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(344, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(192, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 38);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(46, 24);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 38);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(648, 24);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 38);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 508);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 88);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(lbSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 113);
            panel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbProductName);
            groupBox1.Controls.Add(rbProductID);
            groupBox1.Location = new Point(14, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 44);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbProductName
            // 
            rbProductName.AutoSize = true;
            rbProductName.Checked = true;
            rbProductName.Location = new Point(129, 14);
            rbProductName.Name = "rbProductName";
            rbProductName.Size = new Size(125, 24);
            rbProductName.TabIndex = 0;
            rbProductName.TabStop = true;
            rbProductName.Text = "Product Name";
            rbProductName.UseVisualStyleBackColor = true;
            // 
            // rbProductID
            // 
            rbProductID.AutoSize = true;
            rbProductID.Location = new Point(6, 14);
            rbProductID.Name = "rbProductID";
            rbProductID.Size = new Size(100, 24);
            rbProductID.TabIndex = 0;
            rbProductID.TabStop = true;
            rbProductID.Text = "Product ID";
            rbProductID.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(73, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(14, 24);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProductList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 395);
            panel3.TabIndex = 13;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Dock = DockStyle.Fill;
            dgvProductList.Location = new Point(0, 0);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(800, 395);
            dgvProductList.TabIndex = 0;
            // 
            // frmProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmProductList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product List";
            Load += frmProductList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnOrder;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton rbProductName;
        private RadioButton rbProductID;
        private TextBox txtSearch;
        private Label lbSearch;
        private Panel panel3;
        private DataGridView dgvProductList;
    }
}