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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
            this.Hide();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
