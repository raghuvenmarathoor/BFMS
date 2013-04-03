using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace bfmsproject
{
    public partial class MDImainwnd : Form
    {
        private int childFormNumber = 0;
        private bool altkey = false;

        public MDImainwnd()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDImainwnd_Load(object sender, EventArgs e)
        {
            try
            {
                int width = this.Width;
                label1.Location = new Point(width - 300, label1.Location.Y);
                dataGridViewRequirementlist.Location = new Point(width - 300, dataGridViewRequirementlist.Location.Y);
                dataGridViewRequirementlist.Update();
                string sqlqry = "select productdetails.itemname,SUM(productionorder.quantity) from productionorder,productdetails where productionorder.productID=productdetails.productID group by productdetails.itemname,productdetails.productID,productionorder.orderstatus having productionorder.orderstatus=0";
                //string sqlqry = "select distinct productdetails.itemname,SUM(productionorder.quantity),count(product.productID) from product,productionorder,productdetails where productionorder.productID=productdetails.productID and product.productID=productionorder.productID  group by product.salestatus,product.productID,productdetails.itemname,productdetails.productID,productionorder.orderstatus having productionorder.orderstatus=0 and product.salestatus='INSTOCK'";
                SqlDataReader dr = dbConnection.query(sqlqry);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewRequirementlist.DataSource = dt;
                Login lgn = new Login();
                lgn.ShowDialog();
                dataGridViewRequirementlist.Columns[0].HeaderText = "Product Name";
                dataGridViewRequirementlist.Columns[1].HeaderText = "Quantity Required";
                
               
            }
            catch
            {
            }
        }

       

        private void creditRepaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomer edtcust = new EditCustomer();
            edtcust.MdiParent = MDImainwnd.ActiveForm;
            edtcust.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductDetail adproddet = new AddProductDetail();
            adproddet.MdiParent = MDImainwnd.ActiveForm;
            adproddet.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory adcat = new AddCategory();
            label1.Hide();
            dataGridViewRequirementlist.Hide();
            adcat.MdiParent = MDImainwnd.ActiveForm;
            adcat.Show();
           
            
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer adcust = new AddCustomer();
            adcust.MdiParent = MDImainwnd.ActiveForm;
            adcust.Show();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockUpdate stkup = new StockUpdate();
            stkup.MdiParent = MDImainwnd.ActiveForm;
            stkup.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStockbySearch vstk = new ViewStockbySearch();
            vstk.MdiParent = MDImainwnd.ActiveForm;
            vstk.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewRequirementlist.Hide();
            label1.Hide();
            
            BillingSales billsale = new BillingSales();
            billsale.Disposed += new EventHandler(billsale_Disposed);
            billsale.MdiParent = MDImainwnd.ActiveForm;
            billsale.Show();
            
            
        }

        void billsale_Disposed(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRequirementlist.Show();
                label1.Show();
                throw new NotImplementedException();
            }
            catch
            {
            }
            
            
        }

        private void creditRepaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreditRepayment crrepay = new CreditRepayment();
            crrepay.MdiParent = MDImainwnd.ActiveForm;
            crrepay.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.MdiParent = MDImainwnd.ActiveForm;
            lgn.Show();
        }

        private void customerCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerCreditCheck ccrecheck = new CustomerCreditCheck();
            ccrecheck.MdiParent = MDImainwnd.ActiveForm;

            ccrecheck.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewReportOfProductsRequiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Requirement_List prodreq = new Product_Requirement_List();
            prodreq.MdiParent = MDImainwnd.ActiveForm;
            prodreq.Show();
        }

        private void customerCreditReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void viewOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrderHistory vorder = new ViewOrderHistory();
            vorder.MdiParent = MDImainwnd.ActiveForm;
            vorder.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProducts ordprods = new OrderProducts();
            ordprods.MdiParent= MDImainwnd.ActiveForm;
            ordprods.Show();

        }

        private void printOldBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewRequirementlist.Hide();
            label1.Hide();
            
            OldBill old = new OldBill();
            old.Disposed += new EventHandler(old_Disposed);
            old.MdiParent = MDImainwnd.ActiveForm;
            
            old.Show();

        }

        void old_Disposed(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRequirementlist.Show();
                label1.Show();
                throw new NotImplementedException();
            }
            catch
            {
            }
        }

        private void billingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillSettings blset = new BillSettings();
            blset.MdiParent = MDImainwnd.ActiveForm;
            blset.Show();
        }
       // private bool alt = false;
        private void MDImainwnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                altkey = true;
                MessageBox.Show("alt key");
            }
            if (altkey == true && e.KeyCode == Keys.B)
            {
                salesToolStripMenuItem_Click(sender, e);
            }

        }

        private void MDImainwnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                altkey = false;
            }

        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn();
            sr.MdiParent = MDImainwnd.ActiveForm;
            sr.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCategory edcat = new EditCategory();
            edcat.MdiParent = MDImainwnd.ActiveForm;
            edcat.Show();
        }
    }
}
