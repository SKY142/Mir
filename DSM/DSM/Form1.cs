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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            login l = new login( usertxt.Text , Passtxt.Text);
            if (l.check())
            {
                this.Hide();
            }
        }
    }
}
