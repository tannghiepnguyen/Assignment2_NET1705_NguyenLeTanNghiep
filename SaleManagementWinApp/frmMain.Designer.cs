namespace SaleManagementWinApp
{
    partial class frmMain
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
            btnExit = new Button();
            btnLogout = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnProfile = new Button();
            btnOrder = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            pnlForCustomer = new Panel();
            pnlForAdmin = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            pnlForCustomer.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(28, 91);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(28, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 46);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(143, 62);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(174, 46);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(143, 62);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(338, 46);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(143, 62);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(6, 46);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(143, 62);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pnlForCustomer);
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 162);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(656, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(144, 162);
            panel4.TabIndex = 2;
            // 
            // pnlForCustomer
            // 
            pnlForCustomer.Controls.Add(btnProduct);
            pnlForCustomer.Controls.Add(btnProfile);
            pnlForCustomer.Controls.Add(btnOrder);
            pnlForCustomer.Dock = DockStyle.Left;
            pnlForCustomer.Location = new Point(169, 0);
            pnlForCustomer.Name = "pnlForCustomer";
            pnlForCustomer.Size = new Size(487, 162);
            pnlForCustomer.TabIndex = 1;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(btnCustomer);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(169, 162);
            pnlForAdmin.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 165);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlForCustomer.ResumeLayout(false);
            pnlForAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnExit;
        private Button btnLogout;
        private Button btnProduct;
        private Button btnCustomer;
        private Button btnOrder;
        private Button btnProfile;
        private Panel panel1;
        private Panel panel4;
        private Panel pnlForCustomer;
        private Panel pnlForAdmin;
    }
}