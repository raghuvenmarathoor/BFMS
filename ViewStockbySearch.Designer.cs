namespace bfmsproject
{
    partial class ViewStockbySearch
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
            this.dataGridEntireStock = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonViewallstock1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxctgoryid = new System.Windows.Forms.TextBox();
            this.textBoxprodid = new System.Windows.Forms.TextBox();
            this.buttoncheckstock1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textstock = new System.Windows.Forms.TextBox();
            this.comboproname = new System.Windows.Forms.ComboBox();
            this.combocategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntireStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEntireStock
            // 
            this.dataGridEntireStock.AllowUserToAddRows = false;
            this.dataGridEntireStock.AllowUserToDeleteRows = false;
            this.dataGridEntireStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEntireStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntireStock.Location = new System.Drawing.Point(47, 276);
            this.dataGridEntireStock.Name = "dataGridEntireStock";
            this.dataGridEntireStock.ReadOnly = true;
            this.dataGridEntireStock.RowHeadersVisible = false;
            this.dataGridEntireStock.Size = new System.Drawing.Size(508, 158);
            this.dataGridEntireStock.TabIndex = 0;
            this.dataGridEntireStock.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(157, 449);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 51);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(297, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 51);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonViewallstock1
            // 
            this.buttonViewallstock1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewallstock1.Location = new System.Drawing.Point(47, 247);
            this.buttonViewallstock1.Name = "buttonViewallstock1";
            this.buttonViewallstock1.Size = new System.Drawing.Size(198, 23);
            this.buttonViewallstock1.TabIndex = 8;
            this.buttonViewallstock1.Text = "View the entire Stock";
            this.buttonViewallstock1.UseVisualStyleBackColor = true;
            this.buttonViewallstock1.Click += new System.EventHandler(this.buttonViewallstock1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBoxctgoryid);
            this.groupBox1.Controls.Add(this.textBoxprodid);
            this.groupBox1.Controls.Add(this.buttoncheckstock1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textstock);
            this.groupBox1.Controls.Add(this.comboproname);
            this.groupBox1.Controls.Add(this.combocategory);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxctgoryid
            // 
            this.textBoxctgoryid.Enabled = false;
            this.textBoxctgoryid.Location = new System.Drawing.Point(263, 43);
            this.textBoxctgoryid.Name = "textBoxctgoryid";
            this.textBoxctgoryid.Size = new System.Drawing.Size(100, 20);
            this.textBoxctgoryid.TabIndex = 16;
            // 
            // textBoxprodid
            // 
            this.textBoxprodid.Enabled = false;
            this.textBoxprodid.Location = new System.Drawing.Point(263, 88);
            this.textBoxprodid.Name = "textBoxprodid";
            this.textBoxprodid.Size = new System.Drawing.Size(100, 20);
            this.textBoxprodid.TabIndex = 15;
            // 
            // buttoncheckstock1
            // 
            this.buttoncheckstock1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncheckstock1.Location = new System.Drawing.Point(79, 149);
            this.buttoncheckstock1.Name = "buttoncheckstock1";
            this.buttoncheckstock1.Size = new System.Drawing.Size(121, 34);
            this.buttoncheckstock1.TabIndex = 14;
            this.buttoncheckstock1.Text = "Check Stock";
            this.buttoncheckstock1.UseVisualStyleBackColor = true;
            this.buttoncheckstock1.Click += new System.EventHandler(this.buttoncheckstock1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stock Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category";
            // 
            // textstock
            // 
            this.textstock.Enabled = false;
            this.textstock.Location = new System.Drawing.Point(263, 157);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(121, 20);
            this.textstock.TabIndex = 10;
            // 
            // comboproname
            // 
            this.comboproname.FormattingEnabled = true;
            this.comboproname.Location = new System.Drawing.Point(79, 88);
            this.comboproname.Name = "comboproname";
            this.comboproname.Size = new System.Drawing.Size(121, 21);
            this.comboproname.TabIndex = 9;
            this.comboproname.SelectedIndexChanged += new System.EventHandler(this.comboproname_SelectedIndexChanged);
            // 
            // combocategory
            // 
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Location = new System.Drawing.Point(79, 43);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(121, 21);
            this.combocategory.TabIndex = 8;
            this.combocategory.SelectedIndexChanged += new System.EventHandler(this.combocategory_SelectedIndexChanged);
            // 
            // ViewStockbySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(607, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonViewallstock1);
            this.Controls.Add(this.dataGridEntireStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewStockbySearch";
            this.Text = "View Stock ";
            this.Load += new System.EventHandler(this.ViewStockbySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntireStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEntireStock;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonViewallstock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttoncheckstock1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.ComboBox comboproname;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.TextBox textBoxprodid;
        private System.Windows.Forms.TextBox textBoxctgoryid;
    }
}