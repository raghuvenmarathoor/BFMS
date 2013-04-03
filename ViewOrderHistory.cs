using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bfmsproject
{
    public partial class ViewOrderHistory : Form
    {
        public ViewOrderHistory()
        {
            InitializeComponent();
        }
        private void updatedatagridview(int noofdays)
        {
            try
            {
                TimeSpan timespn = new TimeSpan(noofdays, 0, 0, 0);
                DateTime dt = DateTime.Now.Subtract(timespn);
                string sqlqry = "";
                if (false==checkBox1.Checked)
                {
                    sqlqry = "select productionorder.orderID,productdetails.itemname,productionorder.quantity,customer.customername,productionorder.requestdate from productionorder,productdetails,customer where requestdate>'" + dt.ToShortDateString() + "' and productdetails.productID=productionorder.productID and customer.customer_id=productionorder.customerID";
                }
                else
                {
                    sqlqry = "select productionorder.orderID,productdetails.itemname,productionorder.quantity,customer.customername,productionorder.requestdate from productionorder,productdetails,customer where requestdate>'" + dt.ToShortDateString() + "' and productdetails.productID=productionorder.productID and customer.customer_id=productionorder.customerID and productionorder.orderstatus=0";
                }
                SqlDataReader dr = dbConnection.query(sqlqry);
                DataTable datatable = new DataTable();
                datatable.Load(dr);
                dataGridView1.DataSource = datatable;
                dataGridView1.Update();
            }
            catch
            {
            }

            }
        private void ViewOrderHistory_Load(object sender, EventArgs e)
        {
          //  updatedatagridview(7);
        }

        private void radioButtonWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeek.Checked)
            {
                updatedatagridview(7);
            }

        }

        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonth.Checked)
            {
                updatedatagridview(30);
            }

        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeek.Checked)
            {
                updatedatagridview(365);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonWeek.Checked)
                updatedatagridview(7);
            if (radioButtonMonth.Checked)
                updatedatagridview(30);
            if (radioButtonYear.Checked)
                updatedatagridview(365);
        }
    }
}
