using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace bfmsproject
{
    public partial class StockUpdate : Form
    {
        
        public StockUpdate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        BillPrintingDataSet datasetserialno = new BillPrintingDataSet();
        private void StockUpdate_Load(object sender, EventArgs e)
        {
            //SqlDataReader dr = dbConnection.query("select categoryID from category");
            //DataGridViewComboBoxColumn dcombo = new DataGridViewComboBoxColumn();
            //dcombo.FlatStyle = FlatStyle.Flat;
            //dcombo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //dcombo.AutoComplete = true;
            
            //while (dr.Read())
            //{
            //    dcombo.Items.Add(dr[0].ToString());
            //}
            //dataGridView1.Columns.Add(dcombo);
            //dataGridView1.Columns[0].HeaderText = "Category";
           

            DataGridViewComboBoxColumn dcombo1 = new DataGridViewComboBoxColumn();
            //dcombo.FlatStyle = FlatStyle.Flat;
            dcombo1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dcombo1.AutoComplete = true;
            SqlDataReader dr = dbConnection.query("select itemname from productdetails");
            while (dr.Read())
            {
                dcombo1.Items.Add(dr[0].ToString());
            }
            dataGridView1.Columns.Add(dcombo1);
            
            dataGridView1.Columns[0].HeaderText = "Product Name";
            dataGridView1.Columns.Add("Quantity", "Quantity");
            
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox c = e.Control as ComboBox;
            if (c != null)
            {

                c.DropDownStyle = ComboBoxStyle.DropDown;
                c.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {

            DialogResult dialogresultd = new DialogResult();
            dialogresultd=MessageBox.Show("Are you sure?","Confirm Stock Update",MessageBoxButtons.YesNo);
            if (dialogresultd == DialogResult.Yes)
            {

                int rowcount = dataGridView1.RowCount - 2;
                //int row = 0;
                Int32 row = 0;
                string productid, qry;
                int quantity;
                int tempqty;
                Int32 serialno = 1000;
                
                while (row <= rowcount)
                {
                    quantity = Convert.ToInt32(dataGridView1.Rows[row].Cells[1].Value);
                    
                    SqlDataReader dproid = dbConnection.query("select productID from productdetails where itemname='" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");
                    dproid.Read();

                    productid = dproid[0].ToString();
                    tempqty = quantity;

                    SqlDataReader dr = dbConnection.query("select MAX(serialno) from product");
                    if (dr.Read())
                    {
                        if (dr[0].ToString() != "")
                        {
                            serialno = Convert.ToInt32(dr[0].ToString());
                        }
                        else
                            serialno = 1000;
                    }
                    while (tempqty > 0)
                    {
                        serialno = Convert.ToInt32(IDGenerator.generatenext(serialno.ToString()));
                        datasetserialno.serialnolabel.AddserialnolabelRow(productid.ToString(),serialno.ToString());
                        qry = "insert into product values('" + productid + "','" + serialno.ToString() + "','INSTOCK')";
                        // MessageBox.Show(tempqty.ToString());
                        dbConnection.exenonquery(qry);
                        tempqty--;
                    }
                    row++;
                }
                MessageBox.Show("Products added to Stock");
                printserialno();
                dataGridView1.Rows.Clear();
            }

           
        }
        private void printserialno()
        {
            DialogResult rs = MessageBox.Show("Do you want to print the Serial Number labels for the updated stock products?", "Print Serial Numbers", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                crystalreportserialno crys = new crystalreportserialno();
                crys.SetDataSource(datasetserialno);
                ShowReports rpts = new ShowReports(crys);
                rpts.Show();
                
            }
        }


        private void textQty_Leave(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
