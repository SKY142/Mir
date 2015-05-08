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
    public partial class AdminFormcs : Form
    {
        public AdminFormcs()
        {
            InitializeComponent();
        }

        private void Prdbtn_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.Show();
            this.Hide();
        }
    }
}
