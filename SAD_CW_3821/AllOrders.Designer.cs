namespace SAD_CW_3821
{
    partial class AllOrders
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
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderManagementDBDataSetOrders = new SAD_CW_3821.OrderManagementDBDataSetOrders();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rdbOpen = new System.Windows.Forms.RadioButton();
            this.rdbProcessed = new System.Windows.Forms.RadioButton();
            this.rdbCanceled = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.grbSort = new System.Windows.Forms.GroupBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.orderLinesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderManagementDBDataSetOrderLines = new SAD_CW_3821.OrderManagementDBDataSetOrderLines();
            this.ordersTableTableAdapter = new SAD_CW_3821.OrderManagementDBDataSetOrdersTableAdapters.OrdersTableTableAdapter();
            this.orderLinesTableTableAdapter = new SAD_CW_3821.OrderManagementDBDataSetOrderLinesTableAdapters.OrderLinesTableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalForItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrders)).BeginInit();
            this.grbFilter.SuspendLayout();
            this.grbSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.AllowUserToAddRows = false;
            this.dgvAllOrders.AllowUserToDeleteRows = false;
            this.dgvAllOrders.AllowUserToResizeColumns = false;
            this.dgvAllOrders.AllowUserToResizeRows = false;
            this.dgvAllOrders.AutoGenerateColumns = false;
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvAllOrders.DataSource = this.ordersTableBindingSource;
            this.dgvAllOrders.Location = new System.Drawing.Point(12, 32);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.ReadOnly = true;
            this.dgvAllOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllOrders.Size = new System.Drawing.Size(768, 219);
            this.dgvAllOrders.TabIndex = 0;
            this.dgvAllOrders.SelectionChanged += new System.EventHandler(this.dgvAllOrders_SelectionChanged);
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
            // btnProcessed
            // 
            this.btnProcessed.Location = new System.Drawing.Point(786, 32);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(75, 23);
            this.btnProcessed.TabIndex = 1;
            this.btnProcessed.Text = "Processed";
            this.btnProcessed.UseVisualStyleBackColor = true;
            this.btnProcessed.Click += new System.EventHandler(this.btnProcessed_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.Location = new System.Drawing.Point(786, 61);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(75, 23);
            this.btnCanceled.TabIndex = 2;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(786, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(786, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(786, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rdbOpen
            // 
            this.rdbOpen.AutoSize = true;
            this.rdbOpen.Location = new System.Drawing.Point(17, 19);
            this.rdbOpen.Name = "rdbOpen";
            this.rdbOpen.Size = new System.Drawing.Size(51, 17);
            this.rdbOpen.TabIndex = 6;
            this.rdbOpen.Text = "Open";
            this.rdbOpen.UseVisualStyleBackColor = true;
            this.rdbOpen.CheckedChanged += new System.EventHandler(this.rdbOpen_CheckedChanged);
            // 
            // rdbProcessed
            // 
            this.rdbProcessed.AutoSize = true;
            this.rdbProcessed.Location = new System.Drawing.Point(17, 42);
            this.rdbProcessed.Name = "rdbProcessed";
            this.rdbProcessed.Size = new System.Drawing.Size(75, 17);
            this.rdbProcessed.TabIndex = 7;
            this.rdbProcessed.Text = "Processed";
            this.rdbProcessed.UseVisualStyleBackColor = true;
            this.rdbProcessed.CheckedChanged += new System.EventHandler(this.rdbProcessed_CheckedChanged);
            // 
            // rdbCanceled
            // 
            this.rdbCanceled.AutoSize = true;
            this.rdbCanceled.Location = new System.Drawing.Point(17, 65);
            this.rdbCanceled.Name = "rdbCanceled";
            this.rdbCanceled.Size = new System.Drawing.Size(70, 17);
            this.rdbCanceled.TabIndex = 8;
            this.rdbCanceled.Text = "Canceled";
            this.rdbCanceled.UseVisualStyleBackColor = true;
            this.rdbCanceled.CheckedChanged += new System.EventHandler(this.rdbCanceled_CheckedChanged);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(17, 88);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(36, 17);
            this.rdbAll.TabIndex = 9;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.rdbOpen);
            this.grbFilter.Controls.Add(this.rdbAll);
            this.grbFilter.Controls.Add(this.rdbProcessed);
            this.grbFilter.Controls.Add(this.rdbCanceled);
            this.grbFilter.Location = new System.Drawing.Point(650, 289);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(130, 116);
            this.grbFilter.TabIndex = 10;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter Order By Status :";
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Checked = true;
            this.rdbAscending.Location = new System.Drawing.Point(18, 19);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(75, 17);
            this.rdbAscending.TabIndex = 11;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            this.rdbAscending.CheckedChanged += new System.EventHandler(this.rdbAscending_CheckedChanged);
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(18, 42);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(82, 17);
            this.rdbDescending.TabIndex = 12;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            this.rdbDescending.CheckedChanged += new System.EventHandler(this.rdbDescending_CheckedChanged);
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rdbAscending);
            this.grbSort.Controls.Add(this.rdbDescending);
            this.grbSort.Location = new System.Drawing.Point(650, 411);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(130, 71);
            this.grbSort.TabIndex = 13;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sort Order By Date:";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AllowUserToResizeColumns = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityOrderedDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn1,
            this.totalForItemDataGridViewTextBoxColumn});
            this.dgvOrderList.DataSource = this.orderLinesTableBindingSource;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 289);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(565, 193);
            this.dgvOrderList.TabIndex = 14;
            // 
            // orderLinesTableBindingSource
            // 
            this.orderLinesTableBindingSource.DataMember = "OrderLinesTable";
            this.orderLinesTableBindingSource.DataSource = this.orderManagementDBDataSetOrderLines;
            // 
            // orderManagementDBDataSetOrderLines
            // 
            this.orderManagementDBDataSetOrderLines.DataSetName = "OrderManagementDBDataSetOrderLines";
            this.orderManagementDBDataSetOrderLines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableTableAdapter
            // 
            this.ordersTableTableAdapter.ClearBeforeFill = true;
            // 
            // orderLinesTableTableAdapter
            // 
            this.orderLinesTableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityOrderedDataGridViewTextBoxColumn
            // 
            this.quantityOrderedDataGridViewTextBoxColumn.DataPropertyName = "QuantityOrdered";
            this.quantityOrderedDataGridViewTextBoxColumn.HeaderText = "Quantity Ordered";
            this.quantityOrderedDataGridViewTextBoxColumn.Name = "quantityOrderedDataGridViewTextBoxColumn";
            this.quantityOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityOrderedDataGridViewTextBoxColumn.Width = 120;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn1
            // 
            this.orderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn1.Name = "orderNumberDataGridViewTextBoxColumn1";
            this.orderNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalForItemDataGridViewTextBoxColumn
            // 
            this.totalForItemDataGridViewTextBoxColumn.DataPropertyName = "TotalForItem";
            this.totalForItemDataGridViewTextBoxColumn.HeaderText = "Total For Item";
            this.totalForItemDataGridViewTextBoxColumn.Name = "totalForItemDataGridViewTextBoxColumn";
            this.totalForItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalForItemDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryAddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "Order Status";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Products in Order";
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCanceled);
            this.Controls.Add(this.btnProcessed);
            this.Controls.Add(this.dgvAllOrders);
            this.Name = "AllOrders";
            this.Text = "All Orders";
            this.Activated += new System.EventHandler(this.AllOrders_Activated);
            this.Load += new System.EventHandler(this.AllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrders)).EndInit();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDBDataSetOrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rdbOpen;
        private System.Windows.Forms.RadioButton rdbProcessed;
        private System.Windows.Forms.RadioButton rdbCanceled;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.RadioButton rdbAscending;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.GroupBox grbSort;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private OrderManagementDBDataSetOrders orderManagementDBDataSetOrders;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private OrderManagementDBDataSetOrdersTableAdapters.OrdersTableTableAdapter ordersTableTableAdapter;
        private OrderManagementDBDataSetOrderLines orderManagementDBDataSetOrderLines;
        private System.Windows.Forms.BindingSource orderLinesTableBindingSource;
        private OrderManagementDBDataSetOrderLinesTableAdapters.OrderLinesTableTableAdapter orderLinesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalForItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}