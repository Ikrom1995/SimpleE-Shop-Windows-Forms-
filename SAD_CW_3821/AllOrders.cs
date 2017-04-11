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
    public partial class AllOrders : Form
    {
        public AllOrders()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["OrderManagement"];
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            RefreshOrders();
            //RefreshOrderList();
            if (dgvAllOrders.RowCount > 0)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                RefreshOrderListByOrderId(order);
            }
            
        }

        public void RefreshOrders()
        {
            //this.productsTableTableAdapter.Fill(this.orderManagementDBDataSetProducts.ProductsTable);
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrders();
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        public void RefreshOrderListByOrderId(OrdersTable order)
        {
            dgvOrderList.SuspendLayout();
            orderLinesTableBindingSource.SuspendBinding();
            orderLinesTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrderLines(order);
            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = orderLinesTableBindingSource;
            orderLinesTableBindingSource.ResumeBinding();
            dgvOrderList.ResumeLayout();
        }

        private void dgvAllOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAllOrders.SelectedRows.Count == 1)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                RefreshOrderListByOrderId(order);
            }
            
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            if (dgvAllOrders.SelectedRows.Count == 1)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                if (order.OrderStatus == OrderStatus.Canceled.ToString())
                {
                    MessageBox.Show("Canceled Order Can Not Be Processed!");
                }
                else if (order.OrderStatus == OrderStatus.Processed.ToString())
                {
                    MessageBox.Show("Order is Already Processed!");
                }
                else
                {
                    order.OrderStatus = OrderStatus.Processed.ToString();
                    OrderingRepository.getInstance.EditOrder(order);
                    RefreshOrders();
                }
                
            }
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            if (dgvAllOrders.SelectedRows.Count == 1)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;

                if (order.OrderStatus == OrderStatus.Processed.ToString())
                {
                    MessageBox.Show("Processed Order Can Not Be Canceled!");
                }
                else if (order.OrderStatus == OrderStatus.Canceled.ToString())
                {
                    MessageBox.Show("Order is Already Canceled!");
                }
                else
                {
                    order.OrderStatus = OrderStatus.Canceled.ToString();
                    OrderingRepository.getInstance.EditOrder(order);
                    RefreshOrders();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllOrders.SelectedRows.Count == 1)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;

                List<OrderLinesTable> orderLines = OrderingRepository.getInstance.GetOrderLines(order);

                foreach (var item in orderLines)
                {
                    OrderingRepository.getInstance.DeleteOrderLine(item);
                }

                OrderingRepository.getInstance.DeleteOrder(order);
                RefreshOrders();
                if (dgvAllOrders.RowCount > 0)
                {
                    OrdersTable anotherOrder = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                    RefreshOrderListByOrderId(anotherOrder);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrdersTable order = new OrdersTable();
            AddOrder form = new AddOrder(order, true);
            form.Show();
            form.FormClosed += AddOrder_FormClosed;
        }

        private void AddOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshOrders();
            if (dgvAllOrders.RowCount > 0)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                RefreshOrderListByOrderId(order);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
            if (order.OrderStatus == OrderStatus.Canceled.ToString())
            {
                MessageBox.Show("Canceled Order Can Not Be Edited");
            }
            else if(order.OrderStatus == OrderStatus.Processed.ToString())
            {
                MessageBox.Show("Processed Order Can Not Be Edited");
            }
            else
            {
                AddOrder form = new AddOrder(order, false);
                form.Show();
            }     
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void rdbCanceled_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrders(rdbCanceled.Text);
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        private void rdbProcessed_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrders(rdbProcessed.Text);
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        private void rdbOpen_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrders(rdbOpen.Text);
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        private void rdbAscending_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrdersByDate(rdbAscending.Text);
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        private void rdbDescending_CheckedChanged(object sender, EventArgs e)
        {
            dgvAllOrders.SuspendLayout();
            ordersTableBindingSource.SuspendBinding();
            ordersTableBindingSource.DataSource = OrderingRepository.getInstance.GetOrdersByDate(rdbDescending.Text);
            dgvAllOrders.DataSource = null;
            dgvAllOrders.DataSource = ordersTableBindingSource;
            ordersTableBindingSource.ResumeBinding();
            dgvAllOrders.ResumeLayout();
        }

        private void AllOrders_Activated(object sender, EventArgs e)
        {
            RefreshOrders();
            if (dgvAllOrders.RowCount > 0)
            {
                OrdersTable order = (OrdersTable)dgvAllOrders.SelectedRows[0].DataBoundItem;
                RefreshOrderListByOrderId(order);
            }
        }
    }
}
