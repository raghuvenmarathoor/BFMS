using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;




namespace bfmsproject
{
    
    public partial class BillingSales : Form
    {
        
        DataTable billDataTable = new DataTable();
       
        
   
    
        decimal discountpercent = 0;
        decimal taxpercent = 12;
        bool parameterconstructorinvoke = false;
        bool oldbill = false;
        bool previewbill = false;
        bool replacementbill = false;
        BillPrintingDataSet prodserial = new BillPrintingDataSet();
        //public BillingSales(string prodid)
        //{
        //    replacementbill = true;
        //    InitializeComponent();

        //}
        public BillingSales(string billno)
        {
            oldbill = true;
            InitializeComponent();
            loadbill();
            textBoxBillNo.Text = billno;
            SqlDataReader dr = dbConnection.query("select billdate,custID,tax,discount,totalamount,cash from billdetails where billno='" + billno + "'");
            if (dr.Read())
            {
                dateTimePickerbilldate.Value =(DateTime) dr[0];
                SqlDataReader dr1 = dbConnection.query("select customername from customer where customer_id='" + dr[1].ToString() + "'");
                dr1.Read();
                comboBoxDealername.SelectedItem = dr1[0].ToString();
                textBoxTax.Text = dr[2].ToString();
                textBoxDiscount.Text = dr[3].ToString();
                textBoxGrandTotal.Text = dr[4].ToString();
                textBoxcash.Text = dr[5].ToString();
                SqlDataReader prodsinbill = dbConnection.query("select productdetails.itemname,count(sales.productID),sales.price from sales,productdetails where productdetails.productID=sales.productID and sales.billno='"+billno+"' group by sales.productID,productdetails.itemname,sales.price");
                float total = 0;
                while (prodsinbill.Read())
                {
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = prodsinbill[0].ToString();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = prodsinbill[1].ToString();
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = prodsinbill[2].ToString();
                    float pr = Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value);
                    float qty = Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value);
                    float t = pr * qty;
                     total = total + t;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = t.ToString();
                }
                textBoxTotal.Text = total.ToString();
                buttonSaveAndPrintBill.Enabled = false;
                groupBox4.Visible = false;
            }



        }
        
        public BillingSales()
        {
            InitializeComponent();
        }
        
        public BillingSales(string customername,string productname, int productrequired,bool replacement)
        {
            replacementbill = replacement;
            InitializeComponent();
            parameterconstructorinvoke = true;
            loadbill();
            
            int i = 0;
            
            foreach (string str in comboBoxDealername.Items)
            {
                if (str == customername)
                    comboBoxDealername.SelectedIndex = i;
                i++;
            }

            dataGridView1.Rows.Add();
            dataGridView1.Update();
            dataGridView1.Rows[0].Cells[0].Value = "1";
            dataGridView1.Rows[0].Cells[1].Value = productname;
            dataGridView1.Rows[0].Cells[2].Value = dbConnection.executescalar("select price from productdetails where itemname='" + productname + "'");
            //MessageBox.Show(dataGridView1.Rows[0].Cells[2].Value.ToString());
            dataGridView1.Rows[0].Cells[3].Value = productrequired.ToString();
            decimal amount=0;
            if(replacement==false)
            amount=(decimal) productrequired* Convert.ToDecimal(dataGridView1.Rows[0].Cells[2].Value);
            else
            amount=0;
            dataGridView1.Rows[0].Cells[4].Value = amount.ToString();
            dataGridView1.Rows[1].Cells[0].Value = "2";
            object send=dataGridView1;
            DataGridViewCellEventArgs cellevent=new DataGridViewCellEventArgs(3,0);
            dataGridView1_CellValueChanged(send, cellevent);
            dataGridView1.AllowUserToAddRows = true;
            

        }
        
        private void loadbill()
        {
            dataGridView1.Enabled = false;
            SqlDataReader drbill = dbConnection.query("select MAX(billno) from billdetails");
            if (drbill.Read())
            {
                if (drbill[0].ToString() != null)
                    textBoxBillNo.Text = IDGenerator.generatenext(drbill[0].ToString());
                else
                    textBoxBillNo.Text = "1";

            }
            else
                textBoxBillNo.Text = "1";
            SqlDataReader drcustomername = dbConnection.query("select customername from customer where active=1");
            while (drcustomername.Read())
            {
                comboBoxDealername.Items.Add(drcustomername[0].ToString());
            }

            comboBoxDealername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDealername.AutoCompleteSource = AutoCompleteSource.ListItems;


            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "slno";
            dataGridView1.Columns[0].HeaderText = "Sl.No";
            DataGridViewComboBoxColumn dcombo = new DataGridViewComboBoxColumn();
            dcombo.FlatStyle = FlatStyle.Flat;
            dcombo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dcombo.AutoComplete = true;
            SqlDataReader dr = dbConnection.query("select itemname from productdetails");
            while (dr.Read())
            {
                dcombo.Items.Add(dr[0].ToString());
            }
            dataGridView1.Columns.Add(dcombo);
            dataGridView1.Columns[1].Name = "productname";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns.Add("rate", "Rate");
            dataGridView1.Columns.Add("quantity", "Qty");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns["rate"].ReadOnly = true;
            if (false==parameterconstructorinvoke)
                dataGridView1.Rows[0].Cells[0].Value = "1";
            //else
            //    dataGridView1.Rows[1].Cells[0].Value = "2";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Update();

            textBoxTotal.Text = "0";
            textBoxGrandTotal.Text = "0";
            textBoxcredit.Text = "0";
            textBoxDiscount.Text = "0";
            textBoxcash.Text = "0";
            textBoxTax.Text = "0";
            radioButtoncash.Select();

        }

        private void BillingSales_Load(object sender, EventArgs e)
        {
            SqlDataReader billset = dbConnection.query("select * from settings");
            if (billset.Read())
            {
                discountpercent = Convert.ToDecimal( billset[2].ToString());
                taxpercent = Convert.ToDecimal(billset[1].ToString());


            }
            
            if (parameterconstructorinvoke == false&&oldbill==false)
                loadbill();
           
           
        }

        

       

       

        private void radioButtoncashandcredit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtoncashandcredit.Checked)
            {
                label11.Visible = true;
                label12.Visible = true;
                textBoxcredit.Visible = true;
                textBoxcash.Visible = true;
                textBoxcredit.Text = textBoxGrandTotal.Text;
                textBoxcash.Focus();

            }
            else
            {
                label11.Visible = false;
                label12.Visible = false;
                textBoxcredit.Visible = false;
                textBoxcash.Visible = false;
                textBoxcash.Text = "0";
                textBoxcredit.Text = "0";

            }
        }

        private void radioButtoncredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (replacementbill == true)
            {
                DialogResult rs = MessageBox.Show("This is a replacement Bill. The old product's status is already updated. Do you still want to cancel the bill?", "Cancel Bill", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == rs)
                {
                    this.Close();
                }
                
            }

            this.Close();
        }

       

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int row = e.RowIndex;
            if (parameterconstructorinvoke == true && row == 1)
            {
            }
            else
            if (row != 0)
            {
                int previousval = Convert.ToInt32(dataGridView1.Rows[row - 1].Cells[0].Value.ToString());
                previousval++;
                dataGridView1.Rows[row].Cells[0].Value = previousval.ToString();
            }
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

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            
           
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            if (dataGridView1.CurrentCell.ColumnIndex==1)
            {
                int rowindex = dataGridView1.RowCount - 2;
                int currentrow = rowindex;
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                string currentcellvalue = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
                while (rowindex >= 0)
                {
                    if (currentcellvalue == dataGridView1.Rows[rowindex].Cells[1].Value.ToString()&&rowindex!=dataGridView1.CurrentCell.RowIndex)
                    {
                        MessageBox.Show("Item already in the list. Change quantity to add this item to list");
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value= "";
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex + 1].Value = "";
                    }
                    rowindex--;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[col - 1].Value.ToString() != null)
                {
                    if (e.ColumnIndex == 2)
                    {
                        try
                        {
                            SqlDataReader dr = dbConnection.query("select price from productdetails where itemname='" + dataGridView1.Rows[e.RowIndex].Cells[col - 1].Value.ToString() + "'");

                            if (dr.Read())
                            {

                                dataGridView1.Rows[e.RowIndex].Cells[2].Value = dr[0].ToString();

                            }
                            else
                                MessageBox.Show("error");
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show("select a valid product " + exp.Message);
                        }


                    }
                    
                   
                }
                
            }
            catch 
            {
                
            }
        }

        private void textBoxcash_TextChanged(object sender, EventArgs e)
        {
            if (false==FieldValidation.integerorfloat(textBoxcash.Text))
            {
                float realval = (float)Convert.ToDouble(textBoxcash.Text);
                textBoxcash.Text = realval.ToString();
                if (textBoxcash.Text != "0")
                {
                    float textbxcsh = (float)Convert.ToDecimal(textBoxcash.Text);
                    float grndtot = (float)Convert.ToDecimal(textBoxGrandTotal.Text);
                    float textbxcre = (float)Convert.ToDecimal(grndtot - textbxcsh);
                    textBoxcredit.Text = textbxcre.ToString();
                }
                else
                    textBoxcredit.Text = Convert.ToDecimal(textBoxcash.Text).ToString();

            }
            
            else
            {
                textBoxcredit.Text = "0";
                textBoxcash.Text = "0";
            }
        }

        private void comboBoxDealername_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            SqlDataReader dr=dbConnection.query("select customer_id from customer where customername='"+comboBoxDealername.SelectedItem.ToString()+"'");
            if(dr.Read())
            {
                textBoxdealerID.Text = dr[0].ToString();
            }
        }

        private void buttonSaveAndPrintBill_Click(object sender, EventArgs e)
        {
            DialogResult dgres = MessageBox.Show("Are you sure that you want to save the bill?", "Confirm Bill", MessageBoxButtons.YesNo);
            try
            {
                if (dgres == DialogResult.Yes)
                {
                    //billno = Convert.ToInt32(textBoxBillNo.Text);
                    string billno = textBoxBillNo.Text;
                    int maxrowindex = dataGridView1.RowCount - 2;
                    int quantity = 0;
                    string productid = "";
                    string price;
                    string serialno;
                    string paytype = "cash";
                    //string cash, credit;
                    if (radioButtoncash.Checked)
                    {
                        paytype = "cash";
                        textBoxcash.Text = textBoxGrandTotal.Text;
                    }
                    if (radioButtoncredit.Checked)
                    {
                        paytype = "cre";
                        textBoxcredit.Text = textBoxGrandTotal.Text;
                    }
                    if (radioButtoncashandcredit.Checked)
                    {
                        paytype = "cshcr";
                        
                    }

                    if (maxrowindex >= 0)
                    {
                        dbConnection.exenonquery("insert into billdetails values('" + billno + "','" + textBoxdealerID.Text + "','" + dateTimePickerbilldate.Value + "','" + textBoxTax.Text + "','" + textBoxDiscount.Text + "','" + textBoxGrandTotal.Text + "','" + paytype + "','" + textBoxcash.Text + "','" + textBoxcredit.Text + "')");
                        SqlDataReader oldcredit = dbConnection.query("select credit from customer where customer_id='" + textBoxdealerID.Text + "'");
                        oldcredit.Read();
                        decimal oldcreditval = Convert.ToDecimal(oldcredit[0].ToString());
                        decimal newcreditval = oldcreditval + Convert.ToDecimal(textBoxcredit.Text);
                        while (maxrowindex >= 0)
                        {
                            SqlDataReader dr = dbConnection.query("select productID,price from productdetails where itemname='" + dataGridView1.Rows[maxrowindex].Cells[1].Value.ToString() + "'");
                            dr.Read();
                            productid = dr[0].ToString();
                            price = dr[1].ToString();
                            quantity = Convert.ToInt32(dataGridView1.Rows[maxrowindex].Cells[3].Value.ToString());
                            dr = dbConnection.query("select top(" + quantity.ToString() + ") serialno from product where productID='" + productid + "' and salestatus='INSTOCK'");
                            while (dr.Read())
                            {
                                serialno = dr[0].ToString();
                                prodserial.serialnolabel.AddserialnolabelRow(productid, serialno);
                                dbConnection.exenonquery("insert into sales values('" + productid + "','" + serialno + "','" + billno + "','" + price + "')");
                                dbConnection.exenonquery("update product set salestatus='SOLD' where serialno='" + serialno + "'");


                            }
                            maxrowindex--;
                        }
                        dbConnection.exenonquery("update customer set credit='" + newcreditval + "' where customer_id='"+textBoxdealerID.Text+"'");
                        printbillreport();
                    }
                    else
                        MessageBox.Show("there are no items to bill");

                    
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error! :" + exp.Message);
            }
        }
        private void printbillreport()
        {
            if (radioButtoncash.Checked)
            {
                textBoxcash.Text = textBoxGrandTotal.Text;
            }
            else if (radioButtoncredit.Checked)
            {
                textBoxcash.Text = "0";
            }
            
           Int32 maxrowindex = dataGridView1.RowCount - 2;
            DialogResult dlgres = MessageBox.Show("Do you want to print the bill now?", "Print Bill Confirmation", MessageBoxButtons.YesNo);
            if (dlgres == DialogResult.Yes)
            {
                BillPrintingDataSet blprintdataset = new BillPrintingDataSet();
                if (maxrowindex < 0 && oldbill==true)
                {
                    maxrowindex++;
                }
                if (maxrowindex >= 0)
                {
                    int i = 0;
                    while (maxrowindex >= i)
                    {
                        if (replacementbill == true&&i==0)
                        {
                            blprintdataset.ItemsTable.AddItemsTableRow(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), "Replacement");
                        }
                        else
                        blprintdataset.ItemsTable.AddItemsTableRow(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString());
                        i++;
                    }
                    BillingReport1 blreport = new BillingReport1();
                    blreport.SetDataSource(blprintdataset);
                    //CrystalDecisions.Shared.ParameterValue parval = new CrystalDecisions.Shared.ParameterValue();
                   
                    //blreport.ParameterFields[0].CurrentValues = textBoxBillNo.Text;
                    //blreport.ParameterFields["billno"].DefaultValues.AddValue(textBoxBillNo.Text);
                    //blreport.ParameterFields["billdate"].DefaultValues.AddValue(dateTimePickerbilldate.Value.ToShortDateString());
                    //blreport.ParameterFields["Customername"].DefaultValues.AddValue(comboBoxDealername.SelectedItem.ToString());
                    //blreport.ParameterFields["TotalAmount"].DefaultValues.AddValue(textBoxTotal.Text);
                    //    blreport.ParameterFields["TaxAmount"].DefaultValues.AddValue(textBoxTax.Text);
                    //    blreport.ParameterFields["DiscountAmount"].DefaultValues.AddValue(textBoxDiscount.Text);
                    //    blreport.ParameterFields["GrandTotal"].DefaultValues.AddValue(textBoxGrandTotal.Text);
                    ParameterField pr = new ParameterField();
                   
                    ParameterFields flds = new ParameterFields();
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    
                    pdv.Value = textBoxBillNo.Text;
                    pr.Name = "billno";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = dateTimePickerbilldate.Value.ToShortDateString();
                    pr.Name = "billdate";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = comboBoxDealername.SelectedItem.ToString();
                    pr.Name = "Customername";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr); 
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = textBoxTotal.Text;
                    pr.Name = "TotalAmount";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = textBoxTax.Text;
                    pr.Name = "TaxAmount";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = textBoxDiscount.Text;
                    pr.Name = "DiscountAmount";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);
                    
                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = textBoxGrandTotal.Text;
                    pr.Name = "GrandTotal";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);

                    pr = new ParameterField();
                    pdv = new ParameterDiscreteValue();
                    pdv.Value = textBoxcash.Text;
                    pr.Name = "cash";
                    pr.CurrentValues.Add(pdv);
                    flds.Add(pr);


                 //   blreport.ParameterFields[0].CurrentValues = 
                    
                        //blreport.SetParameterValue("billno", textBoxBillNo.Text);
                        //blreport.SetParameterValue("billdate", dateTimePickerbilldate.Value.ToShortDateString());
                        //blreport.SetParameterValue("Customername", comboBoxDealername.SelectedItem.ToString());
                        //blreport.SetParameterValue("TotalAmount", textBoxTotal.Text);
                        //blreport.SetParameterValue("TaxAmount", textBoxTax.Text);
                        //blreport.SetParameterValue("DiscountAmount", textBoxDiscount.Text);
                        //blreport.SetParameterValue("GrandTotal", textBoxGrandTotal.Text);
                    ShowReports shwrep = new ShowReports(blreport,flds);
                    shwrep.Show();
                    if (oldbill == false && parameterconstructorinvoke == false&&previewbill==false)
                    {
                        DialogResult dlgresult = MessageBox.Show("Do you want to view the report of productID and serial nos sold by this sale?", "Product ID and Serial Nos", MessageBoxButtons.YesNo);
                        if (dlgresult == DialogResult.Yes)
                        {
                            ParameterFields pfieldsforbilledprods = new ParameterFields();
                            BilledProducts prodsbilled = new BilledProducts();
                            prodsbilled.SetDataSource(prodserial);
                            pr = new ParameterField();
                            pdv = new ParameterDiscreteValue();
                            pdv.Value = textBoxBillNo.Text;
                            pr.Name = "bill";
                            pr.CurrentValues.Add(pdv);
                            pfieldsforbilledprods.Add(pr);
                            ShowReports rpt = new ShowReports(prodsbilled, pfieldsforbilledprods);
                            rpt.Show();

                        }
                    }
                }
                else
                    MessageBox.Show("insert items to Bill First");
            }

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString());
            int col = e.ColumnIndex;
            try
            {
                
                if (e.ColumnIndex == 3&& oldbill==false)
                {
                    if (false == FieldValidation.integervalidation(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))
                    {

                        string productid = "";

                        int availableproduct;
                        string customername = textBoxdealerID.Text;
                        int prodqty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        SqlDataReader dr = dbConnection.query("select productdetails.productID,count(product.productID) from product,productdetails where product.productID=productdetails.productID group by product.productID,productdetails.itemname,productdetails.productID,product.salestatus having productdetails.itemname='" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' and product.salestatus='INSTOCK'");
                        if (dr.Read())
                        {
                            productid = dr[0].ToString();

                            availableproduct = Convert.ToInt32(dr[1].ToString());

                        }
                        else
                        {
                            SqlDataReader proid = dbConnection.query("select productID from productdetails where itemname='" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                            if (proid.Read())
                            {
                                productid = proid[0].ToString();
                            }

                            availableproduct = 0;
                        }
                        if (availableproduct < prodqty)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[3].Value = availableproduct.ToString();
                            int requiredproductcount = prodqty - availableproduct;

                            DialogResult res = MessageBox.Show("There is a shortage of " + requiredproductcount.ToString() + " units in the stock\nDo you want to place an order for the same?", "Confirm Order Placement", MessageBoxButtons.YesNo);
                            if (res == DialogResult.Yes)
                            {

                                OrderProducts ord = new OrderProducts(productid, requiredproductcount.ToString(), customername);
                                ord.ShowDialog();

                            }
                            
                            
                            prodqty = availableproduct;
                        }
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = prodqty.ToString();
                        

                        float productrate = (float)Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());


                        float prodprice = (float)productrate * ((float)prodqty);
                        if (replacementbill == true && e.RowIndex == 0)
                        {
                            dataGridView1.Rows[0].Cells[4].Value = "0";
                        }
                        else
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = prodprice.ToString();
                        int rowindex = dataGridView1.RowCount - 2;
                        //if (parameterconstructorinvoke)
                        //    rowindex = dataGridView1.RowCount - 1;
                        decimal currenttotal = 0;
                        while (rowindex >= 0)
                        {
                            if (dataGridView1.Rows[rowindex].Cells[4].Value.ToString() != "")
                            {
                                currenttotal = currenttotal + Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells[4].Value.ToString());
                            }
                            rowindex--;
                        }
                        textBoxTotal.Text = currenttotal.ToString();
                        decimal taxamount = Convert.ToDecimal((float)(((decimal)taxpercent) / 100 * (decimal)currenttotal));
                        decimal discountamount = Convert.ToDecimal((decimal)(discountpercent / (decimal)100) * (decimal)currenttotal);
                        textBoxTax.Text = taxamount.ToString();
                        textBoxDiscount.Text = discountamount.ToString();
                        currenttotal = currenttotal + taxamount - discountamount;
                        textBoxGrandTotal.Text = currenttotal.ToString();

                    }
                    else
                        MessageBox.Show("Enter valid quantity");
                }
               
               

            }
            catch (Exception exp)
            {
                MessageBox.Show("error  " + exp.Message);
            }

           

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            if (parameterconstructorinvoke)
            {
              //  dataGridView1.Rows.Add();
                //DataGridViewRow dr = new DataGridViewRow();
                //dr.CreateCells(dataGridView1);

                //dataGridView1.Rows.Insert(1, dr);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(e.RowIndex.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (parameterconstructorinvoke == true && dataGridView1.CurrentCell.RowIndex == 0)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            previewbill = true;
            printbillreport();
            previewbill = false;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    OrderProducts ord = new OrderProducts("FLD1001", "10");
        //    ord.ShowDialog();
        //}


        
        
        
    }
}
