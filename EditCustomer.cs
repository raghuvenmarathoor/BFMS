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
    public partial class EditCustomer : Form
    {
       // dbConnection db = new dbConnection();
        public EditCustomer()
        {
            InitializeComponent();
        }
        private void updatecustomer()
        {
            string qry = "update customer set customername='" + textcustname.Text + "', companyname='" + textcompanyname.Text + "', Address='" + textAddress.Text + "', Telephone='" + texttelephone.Text + "', email='" + textemail.Text + "' where customer_id='" + textBoxcustID.Text + "'";
            dbConnection.exenonquery(qry);
        }

        

       
        private void combocustname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr=dbConnection.query("select customer_id from customer where customername='"+combocustname.SelectedItem.ToString()+"'");
            if (dr.Read())
                textBoxcustID.Text = dr[0].ToString();
            else
                textBoxcustID.Text = "";
        }
        private void updatecomboandinitialize()
        {
            combocustname.Items.Clear();
            string sqlqry = "select customername from customer where active=1";
            SqlDataReader dr = dbConnection.query(sqlqry);
            while (dr.Read())
            {
                combocustname.Items.Add(dr[0].ToString());
            }
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            combocustname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (string itm in combocustname.Items)
                acsc.Add(itm);
            combocustname.AutoCompleteCustomSource = acsc;
            combocustname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxcustID.Text = "";
            textcompanyname.Text = "";
            textcustname.Text = "";
            textemail.Text = "";
            texttelephone.Text = "";
            textAddress.Text = "";
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            updatecomboandinitialize();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbConnection.exenonquery("update customer set active=0 where customer_id='"+textBoxcustID.Text+"'");
            MessageBox.Show("invalidated");
        }

        private void combocustname_Leave(object sender, EventArgs e)
        {
            

        }

        private void buttonEditanother_Click(object sender, EventArgs e)
        {
            updatecustomer();
            updatecomboandinitialize();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            updatecustomer();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxcustID_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select customername from customer where customer_id='" + textBoxcustID.Text + "'");
            if (!dr.Read())
            {
                MessageBox.Show("Member not in the list");
                combocustname.Focus();
            }
            else
            {
                IDataReader dr1 = dbConnection.query("select customername,companyname,Address,Telephone,email from customer where customer_id='" + textBoxcustID.Text + "'");
                if (dr1.Read())
                {
                    textcustname.Text = dr1[0].ToString();
                    textcompanyname.Text = dr1["companyname"].ToString();
                    textAddress.Text = dr1["Address"].ToString();
                    texttelephone.Text = dr1["Telephone"].ToString();
                    textemail.Text = dr1["email"].ToString();
                }
            }

        }
    }
}
