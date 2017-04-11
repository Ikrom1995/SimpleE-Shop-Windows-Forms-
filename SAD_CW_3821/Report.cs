using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.DAL;

namespace SAD_CW_3821
{
    public partial class Report : Form
    {

        private List<OrdersTable> processedOrders { get; set; }

        private float totalSales { get; set; }

        public Report()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["OrderManagement"];
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagementDBDataSetOrders.OrdersTable' table. You can move, or remove it, as needed.
            //this.ordersTableTableAdapter.Fill(this.orderManagementDBDataSetOrders.OrdersTable);
            dtpMinDate.MaxDate = DateTime.Now;
            dtpMaxDate.MaxDate = DateTime.Now;
            dtpMinDate.Enabled = false;
            dtpMaxDate.Enabled = false;
            btnApply.Enabled = false;
            RefreshProcessedOrders();
        }

        public void RefreshProcessedOrders()
        {
            totalSales = 0;
            dgvProcessedOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetProcessedOrders();
            dgvProcessedOrders.DataSource = null;
            dgvProcessedOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvProcessedOrders.ResumeLayout();

            processedOrders = OrderingRepository.getInstance.GetProcessedOrders();

            foreach (var item in processedOrders)
            {
                totalSales += (float) item.Total;
            }
            lblTotalSales.Text = totalSales.ToString();
        }

        private void rdbWholePeriod_CheckedChanged(object sender, EventArgs e)
        {
            dtpMaxDate.Enabled = false;
            dtpMinDate.Enabled = false;
            btnApply.Enabled = false;
            RefreshProcessedOrders();
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            dtpMaxDate.Enabled = true;
            dtpMinDate.Enabled = true;
            btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            totalSales = 0;

            dgvProcessedOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetProcessedOrders(dtpMinDate.Value.Date, dtpMaxDate.Value);
            dgvProcessedOrders.DataSource = null;
            dgvProcessedOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvProcessedOrders.ResumeLayout();

            processedOrders = OrderingRepository.getInstance.GetProcessedOrders(dtpMinDate.Value.Date, dtpMaxDate.Value);

            foreach (var item in processedOrders)
            {
                totalSales += (float)item.Total;
            }
            lblTotalSales.Text = totalSales.ToString();
        }
    }
}
