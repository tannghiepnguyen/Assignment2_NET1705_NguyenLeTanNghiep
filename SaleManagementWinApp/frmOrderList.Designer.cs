namespace SaleManagementWinApp
{
    partial class frmOrderList
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
            dgvOrder = new DataGridView();
            dgvOrderDetail = new DataGridView();
            dtpStartDate = new DateTimePicker();
            lbStartDate = new Label();
            dtpEndDate = new DateTimePicker();
            lbEndDate = new Label();
            btnReport = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            pnlForAdmin = new Panel();
            btnClear = new Button();
            lbOrder = new Label();
            lbOrderDetail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            panel1.SuspendLayout();
            pnlForAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(0, 241);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(555, 270);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(620, 241);
            dgvOrderDetail.MultiSelect = false;
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.Size = new Size(533, 270);
            dgvOrderDetail.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(95, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 2;
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(13, 17);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(76, 20);
            lbStartDate.TabIndex = 3;
            lbStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(95, 55);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 2;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(19, 60);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(70, 20);
            lbEndDate.TabIndex = 3;
            lbEndDate.Text = "End Date";
            // 
            // btnReport
            // 
            btnReport.Location = new Point(77, 110);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 29);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(308, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Order";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(538, 557);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(774, 557);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlForAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 157);
            panel1.TabIndex = 7;
            // 
            // pnlForAdmin
            // 
            pnlForAdmin.Controls.Add(btnClear);
            pnlForAdmin.Controls.Add(dtpStartDate);
            pnlForAdmin.Controls.Add(lbStartDate);
            pnlForAdmin.Controls.Add(dtpEndDate);
            pnlForAdmin.Controls.Add(lbEndDate);
            pnlForAdmin.Controls.Add(btnReport);
            pnlForAdmin.Dock = DockStyle.Left;
            pnlForAdmin.Location = new Point(0, 0);
            pnlForAdmin.Name = "pnlForAdmin";
            pnlForAdmin.Size = new Size(383, 157);
            pnlForAdmin.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(200, 110);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrder.Location = new Point(228, 192);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(83, 35);
            lbOrder.TabIndex = 8;
            lbOrder.Text = "Order";
            // 
            // lbOrderDetail
            // 
            lbOrderDetail.AutoSize = true;
            lbOrderDetail.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderDetail.Location = new Point(810, 192);
            lbOrderDetail.Name = "lbOrderDetail";
            lbOrderDetail.Size = new Size(159, 35);
            lbOrderDetail.TabIndex = 8;
            lbOrderDetail.Text = "Order Detail";
            // 
            // frmOrderList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 612);
            Controls.Add(lbOrderDetail);
            Controls.Add(lbOrder);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvOrderDetail);
            Controls.Add(dgvOrder);
            Name = "frmOrderList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            panel1.ResumeLayout(false);
            pnlForAdmin.ResumeLayout(false);
            pnlForAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private DataGridView dgvOrderDetail;
        private DateTimePicker dtpStartDate;
        private Label lbStartDate;
        private DateTimePicker dtpEndDate;
        private Label lbEndDate;
        private Button btnReport;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel1;
        private Panel pnlForAdmin;
        private Label lbOrder;
        private Label lbOrderDetail;
        private Button btnClear;
    }
}