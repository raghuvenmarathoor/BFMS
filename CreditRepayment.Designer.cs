namespace bfmsproject
{
    partial class CreditRepayment
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
            this.buttonpayandprint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textavalcredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPayment = new System.Windows.Forms.TextBox();
            this.ButtonChkCredit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCustname = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonpayandprint
            // 
            this.buttonpayandprint.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpayandprint.Location = new System.Drawing.Point(113, 203);
            this.buttonpayandprint.Name = "buttonpayandprint";
            this.buttonpayandprint.Size = new System.Drawing.Size(120, 69);
            this.buttonpayandprint.TabIndex = 9;
            this.buttonpayandprint.Text = "Pay And Print Receipt";
            this.buttonpayandprint.UseVisualStyleBackColor = true;
            this.buttonpayandprint.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(239, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBoxCustID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textavalcredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPayment);
            this.groupBox1.Controls.Add(this.ButtonChkCredit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboCustname);
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 158);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Enabled = false;
            this.textBoxCustID.Location = new System.Drawing.Point(149, 38);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(119, 20);
            this.textBoxCustID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Credit Amount";
            // 
            // textavalcredit
            // 
            this.textavalcredit.Enabled = false;
            this.textavalcredit.Location = new System.Drawing.Point(149, 86);
            this.textavalcredit.Name = "textavalcredit";
            this.textavalcredit.Size = new System.Drawing.Size(121, 20);
            this.textavalcredit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount";
            // 
            // textPayment
            // 
            this.textPayment.Location = new System.Drawing.Point(149, 123);
            this.textPayment.Name = "textPayment";
            this.textPayment.Size = new System.Drawing.Size(121, 20);
            this.textPayment.TabIndex = 14;
            this.textPayment.TextChanged += new System.EventHandler(this.textPayment_TextChanged);
            this.textPayment.Leave += new System.EventHandler(this.textPayment_Leave);
            // 
            // ButtonChkCredit
            // 
            this.ButtonChkCredit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChkCredit.Location = new System.Drawing.Point(286, 32);
            this.ButtonChkCredit.Name = "ButtonChkCredit";
            this.ButtonChkCredit.Size = new System.Drawing.Size(110, 28);
            this.ButtonChkCredit.TabIndex = 13;
            this.ButtonChkCredit.Text = "Check Credit";
            this.ButtonChkCredit.UseVisualStyleBackColor = true;
            this.ButtonChkCredit.Click += new System.EventHandler(this.ButtonChkCredit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Name";
            // 
            // comboCustname
            // 
            this.comboCustname.FormattingEnabled = true;
            this.comboCustname.Location = new System.Drawing.Point(12, 37);
            this.comboCustname.Name = "comboCustname";
            this.comboCustname.Size = new System.Drawing.Size(121, 21);
            this.comboCustname.TabIndex = 9;
            this.comboCustname.SelectedIndexChanged += new System.EventHandler(this.comboCustname_SelectedIndexChanged);
            // 
            // CreditRepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(475, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonpayandprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreditRepayment";
            this.Text = "Credit Repayment";
            this.Load += new System.EventHandler(this.CreditRepayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonpayandprint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textavalcredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPayment;
        private System.Windows.Forms.Button ButtonChkCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCustname;
        private System.Windows.Forms.TextBox textBoxCustID;
    }
}