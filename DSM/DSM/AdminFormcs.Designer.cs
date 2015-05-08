namespace DSM
{
    partial class AdminFormcs
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
            this.Prdbtn = new System.Windows.Forms.Button();
            this.Signoutbtn = new System.Windows.Forms.Button();
            this.Empbtn = new System.Windows.Forms.Button();
            this.Supbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prdbtn
            // 
            this.Prdbtn.Location = new System.Drawing.Point(68, 92);
            this.Prdbtn.Name = "Prdbtn";
            this.Prdbtn.Size = new System.Drawing.Size(80, 73);
            this.Prdbtn.TabIndex = 0;
            this.Prdbtn.Text = "Add Product";
            this.Prdbtn.UseVisualStyleBackColor = true;
            this.Prdbtn.Click += new System.EventHandler(this.Prdbtn_Click);
            // 
            // Signoutbtn
            // 
            this.Signoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signoutbtn.Location = new System.Drawing.Point(449, 242);
            this.Signoutbtn.Name = "Signoutbtn";
            this.Signoutbtn.Size = new System.Drawing.Size(108, 40);
            this.Signoutbtn.TabIndex = 5;
            this.Signoutbtn.Text = "Sign Out";
            this.Signoutbtn.UseVisualStyleBackColor = true;
            // 
            // Empbtn
            // 
            this.Empbtn.Location = new System.Drawing.Point(233, 92);
            this.Empbtn.Name = "Empbtn";
            this.Empbtn.Size = new System.Drawing.Size(80, 73);
            this.Empbtn.TabIndex = 6;
            this.Empbtn.Text = "Manage Employee";
            this.Empbtn.UseVisualStyleBackColor = true;
            // 
            // Supbtn
            // 
            this.Supbtn.Location = new System.Drawing.Point(401, 92);
            this.Supbtn.Name = "Supbtn";
            this.Supbtn.Size = new System.Drawing.Size(80, 73);
            this.Supbtn.TabIndex = 8;
            this.Supbtn.Text = "Add Supplier";
            this.Supbtn.UseVisualStyleBackColor = true;
            // 
            // AdminFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 298);
            this.Controls.Add(this.Supbtn);
            this.Controls.Add(this.Empbtn);
            this.Controls.Add(this.Signoutbtn);
            this.Controls.Add(this.Prdbtn);
            this.Name = "AdminFormcs";
            this.Text = "AdminFormcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Prdbtn;
        private System.Windows.Forms.Button Signoutbtn;
        private System.Windows.Forms.Button Empbtn;
        private System.Windows.Forms.Button Supbtn;
    }
}