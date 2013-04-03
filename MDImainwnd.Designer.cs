namespace bfmsproject
{
    partial class MDImainwnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDImainwnd));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockUpdationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportOfProductsRequiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditRepaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditRepaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printOldBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRequirementlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.salesReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementlist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.toolStripMenuItem1,
            this.billingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.productToolStripMenuItem.Text = "Add New Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.categoryToolStripMenuItem.Text = "Add New Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManagementToolStripMenuItem,
            this.customerCreditToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.customerManagementToolStripMenuItem.Text = "Customer Management";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // customerCreditToolStripMenuItem
            // 
            this.customerCreditToolStripMenuItem.Name = "customerCreditToolStripMenuItem";
            this.customerCreditToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.customerCreditToolStripMenuItem.Text = "Check Customer Credit";
            this.customerCreditToolStripMenuItem.Click += new System.EventHandler(this.customerCreditToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStockToolStripMenuItem,
            this.viewStockToolStripMenuItem,
            this.stockUpdationHistoryToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // stockUpdationHistoryToolStripMenuItem
            // 
            this.stockUpdationHistoryToolStripMenuItem.Name = "stockUpdationHistoryToolStripMenuItem";
            this.stockUpdationHistoryToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.stockUpdationHistoryToolStripMenuItem.Text = "Stock Updation History";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.viewOrderHistoryToolStripMenuItem,
            this.viewReportOfProductsRequiredToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItem1.Text = "Production";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // viewOrderHistoryToolStripMenuItem
            // 
            this.viewOrderHistoryToolStripMenuItem.Name = "viewOrderHistoryToolStripMenuItem";
            this.viewOrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viewOrderHistoryToolStripMenuItem.Text = "View Order History";
            this.viewOrderHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewOrderHistoryToolStripMenuItem_Click);
            // 
            // viewReportOfProductsRequiredToolStripMenuItem
            // 
            this.viewReportOfProductsRequiredToolStripMenuItem.Name = "viewReportOfProductsRequiredToolStripMenuItem";
            this.viewReportOfProductsRequiredToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viewReportOfProductsRequiredToolStripMenuItem.Text = "Product Requirement List";
            this.viewReportOfProductsRequiredToolStripMenuItem.Click += new System.EventHandler(this.viewReportOfProductsRequiredToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingToolStripMenuItem1,
            this.billingSettingsToolStripMenuItem,
            this.salesReturnToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.billingToolStripMenuItem.Text = "Sales";
            // 
            // billingToolStripMenuItem1
            // 
            this.billingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditRepaymentToolStripMenuItem,
            this.printOldBillToolStripMenuItem});
            this.billingToolStripMenuItem1.Name = "billingToolStripMenuItem1";
            this.billingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.billingToolStripMenuItem1.Text = "Billing";
            // 
            // creditRepaymentToolStripMenuItem
            // 
            this.creditRepaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.creditRepaymentToolStripMenuItem1});
            this.creditRepaymentToolStripMenuItem.Name = "creditRepaymentToolStripMenuItem";
            this.creditRepaymentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditRepaymentToolStripMenuItem.Text = "Create new bill";
            this.creditRepaymentToolStripMenuItem.Click += new System.EventHandler(this.creditRepaymentToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // creditRepaymentToolStripMenuItem1
            // 
            this.creditRepaymentToolStripMenuItem1.Name = "creditRepaymentToolStripMenuItem1";
            this.creditRepaymentToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.creditRepaymentToolStripMenuItem1.Text = "Credit Repayment";
            this.creditRepaymentToolStripMenuItem1.Click += new System.EventHandler(this.creditRepaymentToolStripMenuItem1_Click);
            // 
            // printOldBillToolStripMenuItem
            // 
            this.printOldBillToolStripMenuItem.Name = "printOldBillToolStripMenuItem";
            this.printOldBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printOldBillToolStripMenuItem.Text = "Print Old Bill";
            this.printOldBillToolStripMenuItem.Click += new System.EventHandler(this.printOldBillToolStripMenuItem_Click);
            // 
            // billingSettingsToolStripMenuItem
            // 
            this.billingSettingsToolStripMenuItem.Name = "billingSettingsToolStripMenuItem";
            this.billingSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.billingSettingsToolStripMenuItem.Text = "Billing Settings";
            this.billingSettingsToolStripMenuItem.Click += new System.EventHandler(this.billingSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dataGridViewRequirementlist
            // 
            this.dataGridViewRequirementlist.AllowUserToAddRows = false;
            this.dataGridViewRequirementlist.AllowUserToDeleteRows = false;
            this.dataGridViewRequirementlist.AllowUserToResizeColumns = false;
            this.dataGridViewRequirementlist.AllowUserToResizeRows = false;
            this.dataGridViewRequirementlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequirementlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRequirementlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequirementlist.Location = new System.Drawing.Point(380, 45);
            this.dataGridViewRequirementlist.Name = "dataGridViewRequirementlist";
            this.dataGridViewRequirementlist.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewRequirementlist.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order notification";
            // 
            // salesReturnToolStripMenuItem
            // 
            this.salesReturnToolStripMenuItem.Name = "salesReturnToolStripMenuItem";
            this.salesReturnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesReturnToolStripMenuItem.Text = "Sales Return";
            this.salesReturnToolStripMenuItem.Click += new System.EventHandler(this.salesReturnToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // MDImainwnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRequirementlist);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDImainwnd";
            this.Text = "Battery Factory Management System- Main Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDImainwnd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MDImainwnd_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MDImainwnd_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditRepaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditRepaymentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printOldBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockUpdationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportOfProductsRequiredToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRequirementlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem salesReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}



