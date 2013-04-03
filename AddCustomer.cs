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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            //dbConnection db = new dbConnection();
            string sql = "select MAX(customer_id) from customer";
            SqlDataReader dr = dbConnection.query(sql);
            if (dr.Read())
            {
               // IDGenerator newcustid = new IDGenerator();
                string newval = IDGenerator.generatenext(dr[0].ToString());
                textcustid.Text = newval;
            }
            else
                textcustid.Text = "CUS01";
            
        }

        private void buttonAddnext_Click(object sender, EventArgs e)
        {

            insertCustomer();
            //IDGenerator idgen = new IDGenerator();
            textcustid.Text = IDGenerator.generatenext(textcustid.Text);
            
            textcustname.Text = "";
            textcompname.Text = "";
            textAddress.Text = "";
            texttelephone.Text = "";
            textemail.Text = "";
            


        }

        private void insertCustomer()
        {

           // dbConnection db = new dbConnection();
            string sqlqry = "insert into customer values('" + textcustid.Text + "','" + textcustname.Text + "','" + textcompname.Text + "','" + textAddress.Text + "','" + texttelephone.Text + "','" + textemail.Text + "',0,1)";
            dbConnection.exenonquery(sqlqry);
            MessageBox.Show("One Customer Added");

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            insertCustomer();
            AddCustomer.ActiveForm.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
