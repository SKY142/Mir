namespace DSM
{
    partial class Transaction
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
            this.finishbtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Transaction";
            // 
            // finishbtn
            // 
            this.finishbtn.Location = new System.Drawing.Point(443, 322);
            this.finishbtn.Name = "finishbtn";
            this.finishbtn.Size = new System.Drawing.Size(95, 33);
            this.finishbtn.TabIndex = 51;
            this.finishbtn.Text = "Finish";
            this.finishbtn.UseVisualStyleBackColor = true;
            this.finishbtn.Click += new System.EventHandler(this.finishbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Location = new System.Drawing.Point(341, 322);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(87, 33);
            this.printbtn.TabIndex = 50;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            // 
            // TID
            // 
            this.TID.AutoSize = true;
            this.TID.Location = new System.Drawing.Point(18, 44);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(77, 13);
            this.TID.TabIndex = 42;
            this.TID.Text = "Transaction ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 216);
            this.dataGridView1.TabIndex = 56;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(239, 322);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(87, 33);
            this.backbtn.TabIndex = 59;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "label4";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishbtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.TID);
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishbtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Label TID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label4;
    }
}