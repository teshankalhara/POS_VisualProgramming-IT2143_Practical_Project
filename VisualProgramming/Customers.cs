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
    public partial class Customers : Form
    {
        Form1 form1 = null;
        Dashboard dashboard = null;
        Billing bill = null;
        Categories category = null;

        public Customers()
        {
            InitializeComponent();
        }

        private void closeBtnItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void closeBtnItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categories_Click(object sender, EventArgs e)
        {
            if (category == null || category.IsDisposed)
            {
                category = new Categories();
            }
            this.Hide();
            category.Show();
        }

        private void billing_Click(object sender, EventArgs e)
        {
            if (bill == null || bill.IsDisposed)
            {
                bill = new Billing();
            }
            this.Hide();
            bill.Show();
        }

        private void dashoboards_Click(object sender, EventArgs e)
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new Dashboard();
            }
            this.Hide();
            dashboard.Show();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {

            }
        }

        public bool validate()
        {
            Regex nameValidate = new Regex(@"^[a-zA-Z]");
            Regex phoneVAlidate = new Regex(@"^[0-9]{10}");
            errorProvider1.Clear();

            if (!nameValidate.IsMatch(customerName.Text) || string.IsNullOrEmpty(customerName.Text))
            {
                errorProvider1.SetError(customerName, "Alphabets Only");
                return false;
            }

            
            if (genderBox.SelectedItem == null)
            {
                errorProvider1.SetError(genderBox, "Select Gender");
                return false;
            }
            
            if (!phoneVAlidate.IsMatch(phoneBox.Text) || string.IsNullOrEmpty(phoneBox.Text))
            {
                errorProvider1.SetError(phoneBox, "Alphabets Only");
                return false;
            }
            return true;
        }

        public string getCustomerName()
        {
            return customerName.Text;
        }

        public string getGender()
        {
            return genderBox.SelectedItem.ToString();
        }
        
        public string getPhone()
        {
            return phoneBox.Text;
        }


    }
}
