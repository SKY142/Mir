namespace DSM
{
    partial class Employee
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.EID = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Employee Information";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(509, 306);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(95, 33);
            this.cancelbtn.TabIndex = 40;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(407, 306);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(87, 33);
            this.savebtn.TabIndex = 39;
            this.savebtn.Text = "Add";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(191, 223);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(163, 20);
            this.textBox7.TabIndex = 36;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(191, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 20);
            this.textBox6.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 30;
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Location = new System.Drawing.Point(73, 226);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(36, 13);
            this.sal.TabIndex = 27;
            this.sal.Text = "Salary";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(73, 269);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 26;
            this.password.Text = "Password";
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(73, 184);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(28, 13);
            this.post.TabIndex = 24;
            this.post.Text = "Post";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(73, 140);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 23;
            this.gender.Text = "Gender";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(73, 105);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 22;
            this.name.Text = "Name";
            // 
            // EID
            // 
            this.EID.AutoSize = true;
            this.EID.Location = new System.Drawing.Point(73, 68);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(67, 13);
            this.EID.TabIndex = 21;
            this.EID.Text = "Employee ID";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(443, 31);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(100, 20);
            this.searchtxt.TabIndex = 42;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(549, 31);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 43;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 351);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.password);
            this.Controls.Add(this.post);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.name);
            this.Controls.Add(this.EID);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sal;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label post;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label EID;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
    }
}