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
    public partial class Product_Requirement_List : Form
    {
        bool gridviewbuttonstat = false;
        public Product_Requirement_List()
        {
            InitializeComponent();
        }

        private void Product_Requirement_List_Load(object sender, EventArgs e)
        {
            string sqlqry = "select productdetails.itemname,SUM(productionorder.quantity) from productionorder,productdetails where productionorder.productID=productdetails.productID and productionorder.orderstatus=0 group by productdetails.itemname,productdetails.productID,productionorder.orderstatus";
            SqlDataReader dr = dbConnection.query(sqlqry);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewRequirementList.DataSource = dt;
            this.Width = this.Width - 400;

        }

        private void dataGridViewRequirementList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewRequirementByCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
               // MessageBox.Show("column index "+e.ColumnIndex.ToString());
            if (e.ColumnIndex == 0)
            {
                int availableproduct = Convert.ToInt32(dataGridViewRequirementByCust.Rows[e.RowIndex].Cells[4].Value.ToString());
                int quantityrequired = Convert.ToInt32(dataGridViewRequirementByCust.Rows[e.RowIndex].Cells[3].Value.ToString());
                
                if (availableproduct < quantityrequired)
                    MessageBox.Show("Not enough stock to do the transaction");
                else
                {
                    string customername = dataGridViewRequirementByCust.Rows[e.RowIndex].Cells[2].Value.ToString();
                   
                    int rowindex=dataGridViewRequirementList.CurrentCell.RowIndex;
                   
                    string productname=dataGridViewRequirementList.Rows[rowindex].Cells[0].Value.ToString();
                    string orderid = dataGridViewRequirementByCust.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MessageBox.Show(orderid);
                    BillingSales newbill = new BillingSales(customername, productname, quantityrequired,false);
                    newbill.ShowDialog();
                    string changestate = "update productionorder set deliverystatus='" + quantityrequired.ToString() + "',orderstatus=1 where orderid='"+orderid+"'";
                    dbConnection.exenonquery(changestate);
                    //MessageBox.Show("\nOrderID:" + orderid + "\nproductname:" + productname + "\ncustomername:" + customername + "\nquantityrequired :" + quantityrequired.ToString());


                }

                
               // MessageBox.Show("button clicked");
            }

        }

        private void dataGridViewRequirementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dataGridViewRequirementList.RowCount - 1)
            {
                SqlDataReader dr = dbConnection.query("select productdetails.productID from productdetails where itemname='" + dataGridViewRequirementList.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                dr.Read();
                string productID = dr[0].ToString();
                string sqlqry = "select productionorder.orderID,customer.customername,productionorder.quantity,count(product.productID) from product,productionorder,customer where product.productID=productionorder.productID and customer.customer_ID=productionorder.customerID and productionorder.orderstatus=0 group by productionorder.orderstatus,productionorder.orderID,product.productID,productionorder.customerID,product.salestatus,productionorder.productID,productionorder.quantity,customer.customername having product.salestatus='INSTOCK' and product.productID='" + productID + "'";
               
                dr = dbConnection.query(sqlqry);
                DataTable dt = new DataTable();
                dt.Load(dr);
            dataGridViewRequirementByCust.DataSource = dt;
                if (gridviewbuttonstat == false)
                {
                    DataGridViewButtonColumn dgbut = new DataGridViewButtonColumn();
                    dgbut.HeaderText = "sell product";
                    dgbut.Text = "Sell";
                    dgbut.UseColumnTextForButtonValue = true;
                    dataGridViewRequirementByCust.Columns.Add(dgbut);
                    dataGridViewRequirementByCust.Columns[2].HeaderText = "Quantity Required";
                    dataGridViewRequirementByCust.Columns[3].HeaderText = "Stock Available";
                    dataGridViewRequirementByCust.Update();
                    gridviewbuttonstat = true;
                    this.Width = this.Width + 410;
                    dataGridViewRequirementByCust.Visible = true;
                    label3.Visible = true;
                }
            }
        }

        private void dataGridViewRequirementByCust_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
