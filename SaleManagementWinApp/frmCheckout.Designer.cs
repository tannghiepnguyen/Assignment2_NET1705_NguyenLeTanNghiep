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
            numericAmount = new NumericUpDown();
            lbAmount = new Label();
            btnChangeAmount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
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
            dgvProductListCheckOut.CellClick += dgvProductListCheckOut_CellClick;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(23, 382);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(640, 382);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // numericAmount
            // 
            numericAmount.Enabled = false;
            numericAmount.Location = new Point(96, 316);
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(143, 27);
            numericAmount.TabIndex = 5;
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Location = new Point(28, 318);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(62, 20);
            lbAmount.TabIndex = 6;
            lbAmount.Text = "Amount";
            // 
            // btnChangeAmount
            // 
            btnChangeAmount.Enabled = false;
            btnChangeAmount.Location = new Point(245, 314);
            btnChangeAmount.Name = "btnChangeAmount";
            btnChangeAmount.Size = new Size(94, 29);
            btnChangeAmount.TabIndex = 7;
            btnChangeAmount.Text = "Change";
            btnChangeAmount.UseVisualStyleBackColor = true;
            btnChangeAmount.Click += btnChangeAmount_Click;
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 423);
            Controls.Add(btnChangeAmount);
            Controls.Add(lbAmount);
            Controls.Add(numericAmount);
            Controls.Add(btnClose);
            Controls.Add(btnCheckout);
            Controls.Add(dgvProductListCheckOut);
            Name = "frmCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductListCheckOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductListCheckOut;
        private Button btnCheckout;
        private Button btnClose;
        private NumericUpDown numericAmount;
        private Label lbAmount;
        private Button btnChangeAmount;
    }
}