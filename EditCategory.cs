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
    public partial class EditCategory : Form
    {
        //dbConnection db = new dbConnection();
        public EditCategory()
        {
            InitializeComponent();
        }
        private void updatedatagridview()
        {
            SqlDataReader dr = dbConnection.query("select * from category");
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();

        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            updatedatagridview();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rownumber = e.RowIndex;
            textBoxcatID.Text = dataGridView1.Rows[rownumber].Cells[0].Value.ToString();
            textBoxCatName.Text = dataGridView1.Rows[rownumber].Cells[1].Value.ToString();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dbConnection.exenonquery("update category set categoryname='"+textBoxCatName.Text+"' where categoryid='"+textBoxcatID.Text+"'");
            updatedatagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnection.exenonquery("update category set categoryname='" + textBoxCatName.Text + "' where categoryid='" + textBoxcatID.Text + "'");
            this.Close();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
