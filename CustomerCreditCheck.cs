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
    public partial class CustomerCreditCheck : Form
    {
        public CustomerCreditCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=dbConnection.executescalar("select credit from customer where customername='"+comboCustname.SelectedItem.ToString()+"'");
        }

        private void CustomerCreditCheck_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select customername from customer");
            while (dr.Read())
            {
                comboCustname.Items.Add(dr[0].ToString());
            }
            comboCustname.FlatStyle = FlatStyle.Flat;
            comboCustname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboCustname.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
