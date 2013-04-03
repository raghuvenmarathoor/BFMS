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
    public partial class BillSettings : Form
    {
        public BillSettings()
        {
            InitializeComponent();
        }
        bool allocredit;
        bool initialized = true;
        private void checkBoxCreditAllow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCreditAllow.Checked == true)
            {
                allocredit=true;
                label1.Visible = true;
                textBoxCreditlimit.Visible = true;
            }
        }

        private void BillSettings_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = dbConnection.query("Select * from settings");
                if (dr.Read())
                {
                    if (dr[3].ToString() == "1")
                    {
                        allocredit = true;
                        checkBoxCreditAllow.Checked = true;
                        textBoxCreditlimit.Visible = true;
                        label1.Visible = true;
                        textBoxCreditlimit.Text = dr[0].ToString();
                    }
                    textBoxTaxPercent.Text = dr[1].ToString();
                    textBoxDiscountPercent.Text = dr[2].ToString();

                }
                else
                    initialized = false;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (initialized == false)
            {
                string ins = "insert into settings values('" + textBoxCreditlimit.Text + "','" + textBoxTaxPercent.Text + "','" + textBoxDiscountPercent.Text + "','" + allocredit + "')";
                dbConnection.exenonquery(ins);
            }
            else
            {
                string upd = "update settings set creditlimit='" + textBoxCreditlimit.Text + "', taxpercent='" + textBoxTaxPercent.Text + "',discountpercent='" + textBoxDiscountPercent.Text + "'allowcredit='" + allocredit + "'";
                dbConnection.exenonquery(upd);
            }
        }
    }
}
