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
    public partial class SalesReturn : Form
    {
        public SalesReturn()
        {
            InitializeComponent();
        }
        string prodid="";
        string customerid = "";
        bool insufficientstock=false;
        private void SalesReturn_Load(object sender, EventArgs e)
        {

        }
        
        private void textBoxSnoDefective_Leave(object sender, EventArgs e)
        {
            SqlDataReader dr = dbConnection.query("select sales.billno,billdetails.billdate,sales.productID,billdetails.custID from sales,billdetails where sales.billno=billdetails.billno and sales.serialno='" + textBoxSnoDefective.Text + "'");
            if (dr.Read())
            {
                textBoxBillNo.Text = dr[0].ToString();
                textBoxBillDate.Text = dr[1].ToString();
                prodid=dr[2].ToString();
                int stockcount =Convert.ToInt32( dbConnection.executescalar("select count(product.productID) from product where productID='" + dr[2].ToString() + "' and salestatus='INSTOCK'"));
                customerid = dr[3].ToString();
                if (stockcount == 0)
                {
                    insufficientstock=true;
                    DialogResult rs = MessageBox.Show("The Product is currently out of stock.\nDo you want to place an order?", "Out of stock", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        OrderProducts ordprod = new OrderProducts(prodid, "1", customerid);
                        ordprod.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("Product Not found in sold products. Please try again.");
                textBoxSnoDefective.Text = "";
                textBoxSnoDefective.Focus();
            }

        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {
            if (FieldValidation.integervalidation(textBoxSnoDefective.Text))
            {
                MessageBox.Show("Enter a valid serial no");
                textBoxSnoDefective.Text = "";
                textBoxSnoDefective.Focus();
            }
        }

        private void buttonreturnprod_Click(object sender, EventArgs e)
        {
            //string newprod = dbConnection.executescalar("select top(1) serialno from products where productID='" + prodid + "'");
            if (insufficientstock == false)
            {
                DialogResult rs = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    dbConnection.exenonquery("update product set salestatus='REPLACED' where serialno='" + textBoxSnoDefective.Text + "'");
                    string customername=dbConnection.executescalar("select customername from customer where customer_id='"+customerid+"'");
                    string prodname=dbConnection.executescalar("select itemname from productdetails where productID='"+prodid+"'");
                    BillingSales billsale = new BillingSales(customername, prodname, 1,true);
                    billsale.Show();

                }
            }
            else
                MessageBox.Show("Not enough stock to replace the product");
        }
    }
}
