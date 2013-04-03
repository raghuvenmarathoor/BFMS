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
    public partial class CreditRepayment : Form
    {
        public CreditRepayment()
        {
            InitializeComponent();
        }

        private void CreditRepayment_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select customername from customer where active=1");
            while (dr.Read())
            {
                comboCustname.Items.Add(dr[0].ToString());
            }
            comboCustname.FlatStyle = FlatStyle.Flat;
            comboCustname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboCustname.AutoCompleteSource = AutoCompleteSource.ListItems;
            

        }

        private void comboCustname_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCustID.Text = dbConnection.executescalar("select customer_id from customer where customername='" + comboCustname.SelectedItem.ToString() + "'");
            
            textavalcredit.Text = dbConnection.executescalar("select credit from customer where customer_id='" + textBoxCustID.Text + "'");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float currentval =(float)Convert.ToDecimal( dbConnection.executescalar("select credit from customer where customer_id='" + textBoxCustID.Text + "'"));
            float amountpaid = (float)Convert.ToDecimal(textPayment.Text);
            float presentamount = currentval - amountpaid;
            dbConnection.exenonquery("update customer set credit='"+presentamount.ToString()+"' where customer_id='"+textBoxCustID.Text+"'");
            MessageBox.Show("Current credit value:" + presentamount.ToString());

        }

        private void textPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPayment_Leave(object sender, EventArgs e)
        {
            if (true == FieldValidation.integerorfloat(textPayment.Text))
            {
                MessageBox.Show("enter a valid amount");
                textPayment.Text = "";
                textPayment.Focus();
            }
        }

        private void ButtonChkCredit_Click(object sender, EventArgs e)
        {

        }
    }
}
