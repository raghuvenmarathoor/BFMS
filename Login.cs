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
    public partial class Login : Form
    {
        public Login()
        {
            dbConnection.setconstring();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing")
                Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dbConnection db = new dbConnection();
            string sqlqry = "select * from user_detail where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
            SqlDataReader dr = dbConnection.query(sqlqry);
            if (dr.Read())
            {
                Login.ActiveForm.Dispose();
            }
            else
                MessageBox.Show("Login Failed! Check Username and password");
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
