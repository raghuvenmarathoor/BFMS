using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bfmsproject
{
    public partial class ViewStockbySearch : Form
    {
        public ViewStockbySearch()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewallstock1_Click(object sender, EventArgs e)
        {
            string sqlqry="select product.productID,productdetails.itemname,count(product.productID) as stock from product,productdetails where product.productID=productdetails.productID group by product.productID,productdetails.itemname,product.salestatus having product.salestatus='INSTOCK'";
            SqlDataReader dr = dbConnection.query(sqlqry);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridEntireStock.DataSource = dt;
            dataGridEntireStock.Visible=true;
        }

        private void ViewStockbySearch_Load(object sender, EventArgs e)
        {
            SqlDataReader dr= dbConnection.query("select itemname from productdetails");

            while (dr.Read())
            {
                comboproname.Items.Add(dr[0].ToString());
            }
            dr = dbConnection.query("select categoryname from category");
            while (dr.Read())
            {
                combocategory.Items.Add(dr[0].ToString());
            }
            comboproname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboproname.AutoCompleteSource = AutoCompleteSource.ListItems;
            combocategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combocategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            combocategory.DropDownStyle = ComboBoxStyle.Simple;
            comboproname.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void buttoncheckstock1_Click(object sender, EventArgs e)
        {

            SqlDataReader dr=dbConnection.query("select count(productID) from product where salestatus='INSTOCK' and productID='"+textBoxprodid.Text+"'");
            dr.Read();
            textstock.Text = dr[0].ToString();
        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader ctgoryid=dbConnection.query("select categoryID from category where categoryname='"+combocategory.SelectedItem.ToString()+"'");
            
            if(ctgoryid.Read())
            {
                textBoxctgoryid.Text=ctgoryid[0].ToString();
            SqlDataReader dr=dbConnection.query("select itemname from productdetails where categoryID='"+ctgoryid[0].ToString()+"'");
                comboproname.Items.Clear();
                while(dr.Read())
                {
                    comboproname.Items.Add(dr[0].ToString());
                }
            }
        }

        private void comboproname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr=dbConnection.query("select productID from productdetails where itemname='"+comboproname.SelectedItem.ToString()+"'");
            if(dr.Read())
                textBoxprodid.Text=dr[0].ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
