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
    public partial class OldBill : Form
    {
        public OldBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                BillingSales blsale = new BillingSales(textBox1.Text);
                blsale.Show();
            }
        }

        private void OldBill_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select customer_id,customername,companyname,credit from customer");
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewCustomers.DataSource = dt;
            this.Width = this.Width - 550;
        }
        int flag = 0;
        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select * from billdetails where custid='" + dataGridViewCustomers.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewBillDetails.DataSource = dt;
            dataGridViewBillDetails.Update();
            if (flag == 0)
            {
                this.Width = this.Width + 550;
                flag++;
            }
            label2.Visible = true;
            dataGridViewBillDetails.Visible = true;
            label3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to print this bill?", "Print Old Bill", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BillingSales blsale = new BillingSales(dataGridViewBillDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                blsale.MdiParent = MDImainwnd.ActiveForm;
                blsale.Show();
            }

        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
