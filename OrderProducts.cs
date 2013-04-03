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
    public partial class OrderProducts : Form
    {
        int flg = 0;
        public OrderProducts()
        {
            InitializeComponent();
        }
        public OrderProducts(string reqprodid,string reqprodquantity,string customerid)
        {
            

            InitializeComponent();
            loadpagewithdefaults();
            flg = 1;
            
            SqlDataReader dr=dbConnection.query("select categoryname from category where categoryID=(select categoryID from productdetails where productID='"+reqprodid+"')");
            if (dr.Read())
            {
                int i = 0;
                foreach (string str in combocategory.Items)
                {

                    if (str == dr[0].ToString())
                    {
                        combocategory.SelectedIndex = i;
                    }
                    i++;
                }
               
            }
            dr = dbConnection.query("select customername from customer where customer_id='" + customerid + "'");
            if (dr.Read())
            {
                int i = 0;
                foreach (string str in comboBoxCustomerName.Items)
                {

                    if (str == dr[0].ToString())
                    {
                        comboBoxCustomerName.SelectedIndex = i;
                    }
                    i++;
                }
            }
            dr=dbConnection.query("select itemname from productdetails where productID='"+reqprodid+"'");
            if (dr.Read())
            {
                int i=0;
                foreach (string str in comboproname.Items)
                {
                    
                    if (str == dr[0].ToString())
                    {
                        comboproname.SelectedIndex = i;
                    }
                        i++;
                }
               
            }
            textBoxQuantity.Text = reqprodquantity;
            
        }
        private void loadpagewithdefaults()
        {
           
            comboproname.Items.Clear();
            combocategory.Items.Clear();
            textBoxprodid.Text = "";
            textBoxCustomerID.Text = "";
            SqlDataReader dr = dbConnection.query("select itemname from productdetails");
            while (dr.Read())
            {
                comboproname.Items.Add(dr[0].ToString());
            }
            dr = dbConnection.query("select categoryname from category");
            while (dr.Read())
            {
                combocategory.Items.Add(dr[0].ToString());
            }
            dr = dbConnection.query("select customername from customer where active=1");
            while (dr.Read())
            {
                comboBoxCustomerName.Items.Add(dr[0].ToString());
            }
            comboBoxCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboproname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboproname.AutoCompleteSource = AutoCompleteSource.ListItems;
            combocategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combocategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            combocategory.DropDownStyle = ComboBoxStyle.Simple;
            comboproname.DropDownStyle = ComboBoxStyle.Simple;
            comboBoxCustomerName.DropDownStyle = ComboBoxStyle.Simple;
            dr = dbConnection.query("select MAX(orderID) from productionorder");
            if (dr.Read())
            {
                if (dr[0].ToString() != "")
                    textBoxOrderID.Text = IDGenerator.generatenext(dr[0].ToString());
                else
                    textBoxOrderID.Text = "ORD1001";
            }
            textBoxQuantity.Text = "";
            
            //textBoxOrderID.Text=
        }

        private void OrderProducts_Load(object sender, EventArgs e)
        {
            if(flg==0)
            loadpagewithdefaults();   
        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader ctgoryid = dbConnection.query("select categoryID from category where categoryname='" + combocategory.SelectedItem.ToString() + "'");

            if (ctgoryid.Read())
            {

                SqlDataReader dr = dbConnection.query("select itemname from productdetails where categoryID='" + ctgoryid[0].ToString() + "'");
                comboproname.Items.Clear();
                while (dr.Read())
                {
                    comboproname.Items.Add(dr[0].ToString());
                }
            }
        }

        private void comboproname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select productID from productdetails where itemname='" + comboproname.SelectedItem.ToString() + "'");
            if (dr.Read())
                textBoxprodid.Text = dr[0].ToString();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            DateTime dt=DateTime.Now;
            dbConnection.exenonquery("insert into productionorder values('" + textBoxOrderID.Text + "','" + textBoxprodid.Text + "','" + textBoxQuantity.Text + "','" + textBoxCustomerID.Text + "','" + dt+ "','0','0')");
            MessageBox.Show("inserted into the production queue");
            loadpagewithdefaults();

        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select customer_id from customer where customername='" + comboBoxCustomerName.SelectedItem.ToString() + "'");
            if (dr.Read())
                textBoxCustomerID.Text = dr[0].ToString();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
