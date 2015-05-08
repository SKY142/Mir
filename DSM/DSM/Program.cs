using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class login
    {
        string user_input = "";
        string pass_input = "";
        string[] username = new string[2] { "Admin", "emp" };
        string[] password = new string[2] { "admin", "emp" };
        public login(string user, string pass)
        {
            this.user_input = user;
            this.pass_input = pass;
        }
        public bool check()
        {
            if (user_input == username[0] && pass_input == password[0])
            {
                AdminFormcs a = new AdminFormcs();
                a.Show();
                return true;
            }
            else if (user_input == username[1] && pass_input == password[1])
            {
                Customer c = new Customer();
                c.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                return false;
            }
        }
    }

    class product
    {

    }
}
