using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming
{
    public partial class Form1 : Form
    {
        Dashboard dashboard = null;
        string uname = "user";
        string pswrd = "pswrd";
        public Form1()
        {
            InitializeComponent();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logingBtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (dashboard == null || dashboard.IsDisposed)
                {
                    dashboard = new Dashboard();
                }
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Check Username or Password!!");
            }
        }

        public string getUsername()
        {
            return username.Text;
        }

        public string getPassword()
        {
            return password.Text;
        }

        public bool validate()
        {
            if (uname == getUsername() && pswrd == getPassword())
            {
                return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Contact With Our Team");
        }
    }
}
