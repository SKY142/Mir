using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void finishbtn_Click(object sender, EventArgs e)
        {
            Done d = new Done();
            d.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }
    }
}
