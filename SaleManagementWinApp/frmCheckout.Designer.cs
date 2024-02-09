namespace SaleManagementWinApp
{
    partial class frmCheckout
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
            dgvProductListCheckOut = new DataGridView();
            btnCheckout = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).BeginInit();
            SuspendLayout();
            // 
            // dgvProductListCheckOut
            // 
            dgvProductListCheckOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductListCheckOut.Dock = DockStyle.Top;
            dgvProductListCheckOut.Location = new Point(0, 0);
            dgvProductListCheckOut.MultiSelect = false;
            dgvProductListCheckOut.Name = "dgvProductListCheckOut";
            dgvProductListCheckOut.RowHeadersWidth = 51;
            dgvProductListCheckOut.RowTemplate.Height = 29;
            dgvProductListCheckOut.Size = new Size(756, 294);
            dgvProductListCheckOut.TabIndex = 0;
            dgvProductListCheckOut.CellEnter += dgvProductList_CellEnter;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(24, 317);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(641, 317);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 358);
            Controls.Add(btnClose);
            Controls.Add(btnCheckout);
            Controls.Add(dgvProductListCheckOut);
            Name = "frmCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductListCheckOut;
        private Button btnCheckout;
        private Button btnClose;
    }
}