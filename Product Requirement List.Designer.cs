namespace bfmsproject
{
    partial class Product_Requirement_List
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
            this.dataGridViewRequirementList = new System.Windows.Forms.DataGridView();
            this.dataGridViewRequirementByCust = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementByCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequirementList
            // 
            this.dataGridViewRequirementList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequirementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequirementList.Location = new System.Drawing.Point(8, 69);
            this.dataGridViewRequirementList.Name = "dataGridViewRequirementList";
            this.dataGridViewRequirementList.RowHeadersVisible = false;
            this.dataGridViewRequirementList.Size = new System.Drawing.Size(305, 203);
            this.dataGridViewRequirementList.TabIndex = 0;
            this.dataGridViewRequirementList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequirementList_CellClick);
            this.dataGridViewRequirementList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequirementList_CellContentClick);
            // 
            // dataGridViewRequirementByCust
            // 
            this.dataGridViewRequirementByCust.AllowUserToAddRows = false;
            this.dataGridViewRequirementByCust.AllowUserToDeleteRows = false;
            this.dataGridViewRequirementByCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequirementByCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequirementByCust.Location = new System.Drawing.Point(319, 69);
            this.dataGridViewRequirementByCust.Name = "dataGridViewRequirementByCust";
            this.dataGridViewRequirementByCust.ReadOnly = true;
            this.dataGridViewRequirementByCust.RowHeadersVisible = false;
            this.dataGridViewRequirementByCust.Size = new System.Drawing.Size(412, 203);
            this.dataGridViewRequirementByCust.TabIndex = 1;
            this.dataGridViewRequirementByCust.Visible = false;
            this.dataGridViewRequirementByCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequirementByCust_CellClick);
            this.dataGridViewRequirementByCust.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequirementByCust_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Required Products List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click on the datagridview cells to get order details of specific product";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product and customer details";
            this.label3.Visible = false;
            // 
            // Product_Requirement_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(743, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRequirementByCust);
            this.Controls.Add(this.dataGridViewRequirementList);
            this.Name = "Product_Requirement_List";
            this.Text = "Product_Requirement_List";
            this.Load += new System.EventHandler(this.Product_Requirement_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequirementByCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequirementList;
        private System.Windows.Forms.DataGridView dataGridViewRequirementByCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}