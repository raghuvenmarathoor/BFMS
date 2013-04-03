namespace bfmsproject
{
    partial class EditCustomer
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
            this.buttonEditanother = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcustID = new System.Windows.Forms.TextBox();
            this.buttoninvalidateCustomer = new System.Windows.Forms.Button();
            this.combocustname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texttelephone = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textcompanyname = new System.Windows.Forms.TextBox();
            this.textcustname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditanother
            // 
            this.buttonEditanother.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditanother.Location = new System.Drawing.Point(104, 350);
            this.buttonEditanother.Name = "buttonEditanother";
            this.buttonEditanother.Size = new System.Drawing.Size(89, 54);
            this.buttonEditanother.TabIndex = 13;
            this.buttonEditanother.Text = "Edit Another";
            this.buttonEditanother.UseVisualStyleBackColor = true;
            this.buttonEditanother.Click += new System.EventHandler(this.buttonEditanother_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(197, 350);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 54);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(280, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 54);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxcustID);
            this.groupBox1.Controls.Add(this.buttoninvalidateCustomer);
            this.groupBox1.Controls.Add(this.combocustname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer ID";
            // 
            // textBoxcustID
            // 
            this.textBoxcustID.Enabled = false;
            this.textBoxcustID.Location = new System.Drawing.Point(174, 49);
            this.textBoxcustID.Name = "textBoxcustID";
            this.textBoxcustID.Size = new System.Drawing.Size(100, 20);
            this.textBoxcustID.TabIndex = 22;
            this.textBoxcustID.TextChanged += new System.EventHandler(this.textBoxcustID_TextChanged);
            // 
            // buttoninvalidateCustomer
            // 
            this.buttoninvalidateCustomer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninvalidateCustomer.Location = new System.Drawing.Point(300, 35);
            this.buttoninvalidateCustomer.Name = "buttoninvalidateCustomer";
            this.buttoninvalidateCustomer.Size = new System.Drawing.Size(86, 46);
            this.buttoninvalidateCustomer.TabIndex = 21;
            this.buttoninvalidateCustomer.Text = "Invalidate Customer";
            this.buttoninvalidateCustomer.UseVisualStyleBackColor = true;
            this.buttoninvalidateCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // combocustname
            // 
            this.combocustname.FormattingEnabled = true;
            this.combocustname.Location = new System.Drawing.Point(30, 49);
            this.combocustname.Name = "combocustname";
            this.combocustname.Size = new System.Drawing.Size(125, 21);
            this.combocustname.TabIndex = 20;
            this.combocustname.SelectedIndexChanged += new System.EventHandler(this.combocustname_SelectedIndexChanged);
            this.combocustname.Leave += new System.EventHandler(this.combocustname_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.texttelephone);
            this.groupBox2.Controls.Add(this.textemail);
            this.groupBox2.Controls.Add(this.textAddress);
            this.groupBox2.Controls.Add(this.textcompanyname);
            this.groupBox2.Controls.Add(this.textcustname);
            this.groupBox2.Location = new System.Drawing.Point(32, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 216);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Customer Name";
            // 
            // texttelephone
            // 
            this.texttelephone.Location = new System.Drawing.Point(151, 134);
            this.texttelephone.Name = "texttelephone";
            this.texttelephone.Size = new System.Drawing.Size(155, 20);
            this.texttelephone.TabIndex = 15;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(151, 160);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(155, 20);
            this.textemail.TabIndex = 14;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(151, 82);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(155, 46);
            this.textAddress.TabIndex = 17;
            // 
            // textcompanyname
            // 
            this.textcompanyname.Location = new System.Drawing.Point(151, 56);
            this.textcompanyname.Name = "textcompanyname";
            this.textcompanyname.Size = new System.Drawing.Size(155, 20);
            this.textcompanyname.TabIndex = 16;
            // 
            // textcustname
            // 
            this.textcustname.Location = new System.Drawing.Point(151, 30);
            this.textcustname.Name = "textcustname";
            this.textcustname.Size = new System.Drawing.Size(155, 20);
            this.textcustname.TabIndex = 13;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(477, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonEditanother);
            this.Name = "EditCustomer";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditanother;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttoninvalidateCustomer;
        private System.Windows.Forms.ComboBox combocustname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texttelephone;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textcompanyname;
        private System.Windows.Forms.TextBox textcustname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcustID;
    }
}