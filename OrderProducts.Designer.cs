namespace bfmsproject
{
    partial class OrderProducts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxprodid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboproname = new System.Windows.Forms.ComboBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBoxCustomerID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxOrderID);
            this.groupBox1.Controls.Add(this.buttonOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combocategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.textBoxprodid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboproname);
            this.groupBox1.Location = new System.Drawing.Point(47, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 314);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Location = new System.Drawing.Point(296, 161);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dealer Name";
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(149, 161);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomerName.TabIndex = 17;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Order ID";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Enabled = false;
            this.textBoxOrderID.Location = new System.Drawing.Point(149, 20);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(121, 20);
            this.textBoxOrderID.TabIndex = 15;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(296, 213);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(100, 45);
            this.buttonOrder.TabIndex = 14;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category";
            // 
            // combocategory
            // 
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(149, 65);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(121, 21);
            this.combocategory.TabIndex = 12;
            this.combocategory.SelectedIndexChanged += new System.EventHandler(this.combocategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity Required";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(149, 238);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxprodid
            // 
            this.textBoxprodid.Location = new System.Drawing.Point(296, 116);
            this.textBoxprodid.Name = "textBoxprodid";
            this.textBoxprodid.Size = new System.Drawing.Size(100, 20);
            this.textBoxprodid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Name";
            // 
            // comboproname
            // 
            this.comboproname.FormattingEnabled = true;
            this.comboproname.Location = new System.Drawing.Point(149, 116);
            this.comboproname.Name = "comboproname";
            this.comboproname.Size = new System.Drawing.Size(121, 21);
            this.comboproname.TabIndex = 7;
            this.comboproname.SelectedIndexChanged += new System.EventHandler(this.comboproname_SelectedIndexChanged);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(215, 374);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(102, 60);
            this.okbutton.TabIndex = 8;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(535, 467);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderProducts";
            this.Text = "OrderProducts";
            this.Load += new System.EventHandler(this.OrderProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxprodid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboproname;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Button okbutton;

    }
}