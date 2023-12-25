using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming
{
    public partial class Dashboard : Form
    {
        Form1 form1 = null;
        Customers customer = null;
        Billing bill = null;
        Categories category = null;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeBtnItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
            }
            this.Hide();
            form1.Show();
        }

        private void categories_Click(object sender, EventArgs e)
        {
            if(category == null || category.IsDisposed)
            {
                category = new Categories();
            }
            this.Hide();
            category.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            if (customer == null || customer.IsDisposed)
            {
                customer = new Customers();
            }
            this.Hide();
            customer.Show();
        }

        private void billing_Click(object sender, EventArgs e)
        {
            if(bill== null || bill.IsDisposed)
            {
                bill = new Billing();
            }
            this.Hide();
            bill.Show();
        }
    }
}
