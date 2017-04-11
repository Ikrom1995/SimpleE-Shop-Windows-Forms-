namespace SAD_CW_3821
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.dgvProcessedOrders = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderManagementDBDataSetOrders = new SAD_CW_3821.OrderManagementDBDataSetOrders();
            this.ordersTableTableAdapter = new SAD_CW_3821.OrderManagementDBDataSetOrdersTableAdapters.OrdersTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dtpMinDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMaxDate = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbWholePeriod = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessedOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProcessedOrders
            // 
            this.dgvProcessedOrders.AllowUserToAddRows = false;
            this.dgvProcessedOrders.AllowUserToDeleteRows = false;
            this.dgvProcessedOrders.AllowUserToResizeColumns = false;
            this.dgvProcessedOrders.AllowUserToResizeRows = false;
            this.dgvProcessedOrders.AutoGenerateColumns = false;
            this.dgvProcessedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvProcessedOrders.DataSource = this.ordersTableBindingSource;
            this.dgvProcessedOrders.Location = new System.Drawing.Point(12, 54);
            this.dgvProcessedOrders.Name = "dgvProcessedOrders";
            this.dgvProcessedOrders.ReadOnly = true;
            this.dgvProcessedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessedOrders.Size = new System.Drawing.Size(547, 328);
            this.dgvProcessedOrders.TabIndex = 0;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataMember = "OrdersTable";
            this.ordersTableBindingSource.DataSource = this.orderManagementDBDataSetOrders;
            // 
            // orderManagementDBDataSetOrders
            // 
            this.orderManagementDBDataSetOrders.DataSetName = "OrderManagementDBDataSetOrders";
            this.orderManagementDBDataSetOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableTableAdapter
            // 
            this.ordersTableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(81, 398);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "0";
            // 
            // dtpMinDate
            // 
            this.dtpMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMinDate.Location = new System.Drawing.Point(214, 21);
            this.dtpMinDate.Name = "dtpMinDate";
            this.dtpMinDate.Size = new System.Drawing.Size(112, 20);
            this.dtpMinDate.TabIndex = 3;
            // 
            // dtpMaxDate
            // 
            this.dtpMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMaxDate.Location = new System.Drawing.Point(354, 21);
            this.dtpMaxDate.Name = "dtpMaxDate";
            this.dtpMaxDate.Size = new System.Drawing.Size(112, 20);
            this.dtpMaxDate.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(484, 20);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCustom);
            this.groupBox1.Controls.Add(this.rdbWholePeriod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 36);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peroid;";
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Location = new System.Drawing.Point(88, 13);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(60, 17);
            this.rdbCustom.TabIndex = 7;
            this.rdbCustom.Text = "Custom";
            this.rdbCustom.UseVisualStyleBackColor = true;
            this.rdbCustom.CheckedChanged += new System.EventHandler(this.rdbCustom_CheckedChanged);
            // 
            // rdbWholePeriod
            // 
            this.rdbWholePeriod.AutoSize = true;
            this.rdbWholePeriod.Checked = true;
            this.rdbWholePeriod.Location = new System.Drawing.Point(46, 13);
            this.rdbWholePeriod.Name = "rdbWholePeriod";
            this.rdbWholePeriod.Size = new System.Drawing.Size(36, 17);
            this.rdbWholePeriod.TabIndex = 0;
            this.rdbWholePeriod.TabStop = true;
            this.rdbWholePeriod.Text = "All";
            this.rdbWholePeriod.UseVisualStyleBackColor = true;
            this.rdbWholePeriod.CheckedChanged += new System.EventHandler(this.rdbWholePeriod_CheckedChanged);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dtpMaxDate);
            this.Controls.Add(this.dtpMinDate);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProcessedOrders);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessedOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcessedOrders;
        private OrderManagementDBDataSetOrders orderManagementDBDataSetOrders;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private OrderManagementDBDataSetOrdersTableAdapters.OrdersTableTableAdapter ordersTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DateTimePicker dtpMinDate;
        private System.Windows.Forms.DateTimePicker dtpMaxDate;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbWholePeriod;
    }
}