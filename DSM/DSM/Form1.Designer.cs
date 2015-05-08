namespace DSM
{
    partial class Form1
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
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passbtn = new System.Windows.Forms.Label();
            this.userbtn = new System.Windows.Forms.Label();
            this.Signinbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Login";
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(219, 180);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(163, 20);
            this.Passtxt.TabIndex = 42;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(219, 143);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(163, 20);
            this.usertxt.TabIndex = 41;
            // 
            // passbtn
            // 
            this.passbtn.AutoSize = true;
            this.passbtn.Location = new System.Drawing.Point(108, 183);
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(53, 13);
            this.passbtn.TabIndex = 40;
            this.passbtn.Text = "Password";
            // 
            // userbtn
            // 
            this.userbtn.AutoSize = true;
            this.userbtn.Location = new System.Drawing.Point(108, 146);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(55, 13);
            this.userbtn.TabIndex = 39;
            this.userbtn.Text = "Username";
            // 
            // Signinbtn
            // 
            this.Signinbtn.Location = new System.Drawing.Point(307, 215);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(75, 23);
            this.Signinbtn.TabIndex = 38;
            this.Signinbtn.Text = "Sign In";
            this.Signinbtn.UseVisualStyleBackColor = true;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.userbtn);
            this.Controls.Add(this.Signinbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label passbtn;
        private System.Windows.Forms.Label userbtn;
        private System.Windows.Forms.Button Signinbtn;

    }
}

