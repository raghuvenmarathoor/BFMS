namespace bfmsproject
{
    partial class SalesReturn
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonreturnprod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelchkresstock = new System.Windows.Forms.Label();
            this.textBoxBillDate = new System.Windows.Forms.TextBox();
            this.textBoxBillNo = new System.Windows.Forms.TextBox();
            this.buttonchecksno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSnoDefective = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(239, 246);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 48);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(321, 246);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 48);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.buttonreturnprod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelchkresstock);
            this.groupBox1.Controls.Add(this.textBoxBillDate);
            this.groupBox1.Controls.Add(this.textBoxBillNo);
            this.groupBox1.Controls.Add(this.buttonchecksno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSnoDefective);
            this.groupBox1.Location = new System.Drawing.Point(37, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.TextChanged += new System.EventHandler(this.groupBox1_TextChanged);
            // 
            // buttonreturnprod
            // 
            this.buttonreturnprod.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreturnprod.Location = new System.Drawing.Point(374, 180);
            this.buttonreturnprod.Name = "buttonreturnprod";
            this.buttonreturnprod.Size = new System.Drawing.Size(126, 28);
            this.buttonreturnprod.TabIndex = 16;
            this.buttonreturnprod.Text = "Return";
            this.buttonreturnprod.UseVisualStyleBackColor = true;
            this.buttonreturnprod.Click += new System.EventHandler(this.buttonreturnprod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bill Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bill No";
            // 
            // labelchkresstock
            // 
            this.labelchkresstock.AutoSize = true;
            this.labelchkresstock.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchkresstock.Location = new System.Drawing.Point(148, 141);
            this.labelchkresstock.Name = "labelchkresstock";
            this.labelchkresstock.Size = new System.Drawing.Size(231, 19);
            this.labelchkresstock.TabIndex = 13;
            this.labelchkresstock.Text = "Check result and stock availability";
            // 
            // textBoxBillDate
            // 
            this.textBoxBillDate.Enabled = false;
            this.textBoxBillDate.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillDate.Location = new System.Drawing.Point(220, 98);
            this.textBoxBillDate.Name = "textBoxBillDate";
            this.textBoxBillDate.Size = new System.Drawing.Size(132, 26);
            this.textBoxBillDate.TabIndex = 12;
            // 
            // textBoxBillNo
            // 
            this.textBoxBillNo.Enabled = false;
            this.textBoxBillNo.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillNo.Location = new System.Drawing.Point(220, 64);
            this.textBoxBillNo.Name = "textBoxBillNo";
            this.textBoxBillNo.Size = new System.Drawing.Size(132, 26);
            this.textBoxBillNo.TabIndex = 11;
            // 
            // buttonchecksno
            // 
            this.buttonchecksno.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchecksno.Location = new System.Drawing.Point(374, 33);
            this.buttonchecksno.Name = "buttonchecksno";
            this.buttonchecksno.Size = new System.Drawing.Size(126, 28);
            this.buttonchecksno.TabIndex = 10;
            this.buttonchecksno.Text = "Check";
            this.buttonchecksno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "S.No of defective product";
            // 
            // textBoxSnoDefective
            // 
            this.textBoxSnoDefective.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSnoDefective.Location = new System.Drawing.Point(220, 33);
            this.textBoxSnoDefective.Name = "textBoxSnoDefective";
            this.textBoxSnoDefective.Size = new System.Drawing.Size(132, 26);
            this.textBoxSnoDefective.TabIndex = 8;
            this.textBoxSnoDefective.Leave += new System.EventHandler(this.textBoxSnoDefective_Leave);
            // 
            // SalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(614, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalesReturn";
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.SalesReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelchkresstock;
        private System.Windows.Forms.TextBox textBoxBillDate;
        private System.Windows.Forms.TextBox textBoxBillNo;
        private System.Windows.Forms.Button buttonchecksno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSnoDefective;
        private System.Windows.Forms.Button buttonreturnprod;
    }
}