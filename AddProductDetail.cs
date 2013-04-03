using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bfmsproject
{
    
    public partial class AddProductDetail : Form
    {
       // dbConnection db = new dbConnection();
        string catid = "";
        public AddProductDetail()
        {
            InitializeComponent();
        }

        private void AddProductDetail_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select * from category");
            while (dr.Read())
            {
                combocategory.Items.Add(dr[1].ToString());
            }
            combocategory.SelectedIndex = 0;

        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader d=dbConnection.query("select categoryID from category where categoryname='"+combocategory.SelectedItem.ToString()+"'");
            d.Read();
         catid = d[0].ToString();
            SqlDataReader dr=dbConnection.query("select MAX(productID) from productdetails where categoryID='"+d[0].ToString()+"'");
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    textProductId.Text = catid + "1001";
                }
                else
                {
                    //IDGenerator idgen = new IDGenerator();
                    textProductId.Text = IDGenerator.generatenext(dr[0].ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textlength.Text = "";
            textPotentialdifference.Text = "";
            textprice.Text = "";
            textProdCapacity.Text = "";
            textProdname.Text = "";
            textwarranty.Text = "";
            textweight.Text = "";
            textwidth.Text = "";
            textheight.Text = "";
            textdescription.Text = "";
        }

        private void addnewprod()
        {
            dbConnection.exenonquery("insert into productdetails values('"+textProductId.Text+"','"+textProdname.Text+"','"+catid+"','"+textProdCapacity.Text+"','"+textPotentialdifference.Text+"','"+textweight.Text+"','"+textlength.Text+"','"+textwidth.Text+"','"+textheight.Text+"','"+textwarranty.Text+"','"+textprice.Text+"','"+textdescription.Text+"')");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addnewprod();
            //IDGenerator idgen = new IDGenerator();
            textProductId.Text = IDGenerator.generatenext(textProductId.Text);
            textlength.Text = "";
            textPotentialdifference.Text = "";
            textprice.Text = "";
            textProdCapacity.Text = "";
            textProdname.Text = "";
            textwarranty.Text = "";
            textweight.Text = "";
            textwidth.Text = "";
            textheight.Text = "";
            textdescription.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addnewprod();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textprice_Leave(object sender, EventArgs e)
        {
            if (true == FieldValidation.integerorfloat(textprice.Text))
            {
                MessageBox.Show("Enter valid price");
                textprice.Focus();
            }
        }

      
    }
}
