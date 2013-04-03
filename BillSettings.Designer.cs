namespace bfmsproject
{
    partial class BillSettings
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.textBoxTaxPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCreditlimit = new System.Windows.Forms.TextBox();
            this.checkBoxCreditAllow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxDiscountPercent);
            this.groupBox1.Controls.Add(this.textBoxTaxPercent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCreditlimit);
            this.groupBox1.Controls.Add(this.checkBoxCreditAllow);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDiscountPercent
            // 
            this.textBoxDiscountPercent.Location = new System.Drawing.Point(99, 102);
            this.textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            this.textBoxDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscountPercent.TabIndex = 6;
            // 
            // textBoxTaxPercent
            // 
            this.textBoxTaxPercent.Location = new System.Drawing.Point(99, 76);
            this.textBoxTaxPercent.Name = "textBoxTaxPercent";
            this.textBoxTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaxPercent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax Percent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit Limit";
            this.label1.Visible = false;
            // 
            // textBoxCreditlimit
            // 
            this.textBoxCreditlimit.Location = new System.Drawing.Point(99, 47);
            this.textBoxCreditlimit.Name = "textBoxCreditlimit";
            this.textBoxCreditlimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditlimit.TabIndex = 1;
            this.textBoxCreditlimit.Visible = false;
            // 
            // checkBoxCreditAllow
            // 
            this.checkBoxCreditAllow.AutoSize = true;
            this.checkBoxCreditAllow.Location = new System.Drawing.Point(64, 20);
            this.checkBoxCreditAllow.Name = "checkBoxCreditAllow";
            this.checkBoxCreditAllow.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCreditAllow.TabIndex = 0;
            this.checkBoxCreditAllow.Text = "Allow Credit";
            this.checkBoxCreditAllow.UseVisualStyleBackColor = true;
            this.checkBoxCreditAllow.CheckedChanged += new System.EventHandler(this.checkBoxCreditAllow_CheckedChanged);
            // 
            // BillSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(362, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillSettings";
            this.Text = "Bill Settings";
            this.Load += new System.EventHandler(this.BillSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreditlimit;
        private System.Windows.Forms.CheckBox checkBoxCreditAllow;
        private System.Windows.Forms.TextBox textBoxDiscountPercent;
        private System.Windows.Forms.TextBox textBoxTaxPercent;
        private System.Windows.Forms.Button button1;
    }
}