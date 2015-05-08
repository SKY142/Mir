namespace DSM
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.subbtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CusContact = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.Label();
            this.CusID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Customer Information";
            // 
            // signoutbtn
            // 
            this.signoutbtn.Location = new System.Drawing.Point(501, 349);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(95, 33);
            this.signoutbtn.TabIndex = 51;
            this.signoutbtn.Text = "Signout";
            this.signoutbtn.UseVisualStyleBackColor = true;
            this.signoutbtn.Click += new System.EventHandler(this.signoutbtn_Click);
            // 
            // subbtn
            // 
            this.subbtn.Location = new System.Drawing.Point(399, 349);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(87, 33);
            this.subbtn.TabIndex = 50;
            this.subbtn.Text = "Submit";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 46;
            // 
            // CusContact
            // 
            this.CusContact.AutoSize = true;
            this.CusContact.Location = new System.Drawing.Point(334, 122);
            this.CusContact.Name = "CusContact";
            this.CusContact.Size = new System.Drawing.Size(64, 13);
            this.CusContact.TabIndex = 45;
            this.CusContact.Text = "Contact No.";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(36, 119);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(45, 13);
            this.CusAddress.TabIndex = 44;
            this.CusAddress.Text = "Address";
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Location = new System.Drawing.Point(334, 79);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(35, 13);
            this.Cname.TabIndex = 43;
            this.Cname.Text = "Name";
            // 
            // CusID
            // 
            this.CusID.AutoSize = true;
            this.CusID.Location = new System.Drawing.Point(36, 82);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(65, 13);
            this.CusID.TabIndex = 42;
            this.CusID.Text = "Customer ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 165);
            this.dataGridView1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "10000";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signoutbtn);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CusContact);
            this.Controls.Add(this.CusAddress);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.CusID);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signoutbtn;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CusContact;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label Cname;
        private System.Windows.Forms.Label CusID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}