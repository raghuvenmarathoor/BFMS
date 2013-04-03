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
    public partial class AddCategory : Form
    {

        //dbConnection db = new dbConnection();
        public AddCategory()
        {
            InitializeComponent();
        }
        private void Updatedatagridview()
        {
            SqlDataReader dr = dbConnection.query("select * from category");
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {

            Updatedatagridview();
        }

        private void textBoxCatID_Leave(object sender, EventArgs e)
        {
            SqlDataReader dr=dbConnection.query("select * from category where categoryID='"+textBoxCatID.Text+"'");
            if (dr.Read())
            {
                MessageBox.Show("Category ID already exists");
                textBoxCatID.Text = "";
                textBoxCatID.Focus();

            }

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());
            
            
            string sqlqr = "insert into category values('" + textBoxCatID.Text + "','" + textBoxCatName.Text + "')";
            //dbConnection.exenonquery(sqlqr);
            Updatedatagridview();
            textBoxCatName.Text = "";
            textBoxCatID.Text = "";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxCatID.Text != "" || textBoxCatName.Text != "")
            {
                DialogResult dgres = MessageBox.Show("Press Add Button to add the category to database.Do you want to add the current details?","Add New Category",MessageBoxButtons.YesNoCancel);
                if (dgres == DialogResult.Yes)
                {
                    Button btn = new Button();
                    EventArgs args = new EventArgs();
                    buttonAddCategory_Click(btn, args);

                }
                else if (dgres == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                }
            }
            
        }

        
    }
}
