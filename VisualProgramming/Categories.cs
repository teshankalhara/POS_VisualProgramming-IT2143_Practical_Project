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
    public partial class Categories : Form
    {
        Form1 form1 = null;
        Dashboard dashboard = null;
        Billing bill = null;
        Customers customer = null;

        public Categories()
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

        private void customers_Click(object sender, EventArgs e)
        {
            if (customer == null || customer.IsDisposed)
            {
                customer = new Customers();
            }
            this.Hide();
            customer.Show();
        }

        private void dashoboards_Click(object sender, EventArgs e)
        {
            if(dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new Dashboard();
            }
            this.Hide();
            dashboard.Show();
        }

        private void billing_Click(object sender, EventArgs e)
        {
           if(bill == null || bill.IsDisposed)
            {
                bill = new Billing();
            }
            this.Hide();
            bill.Show();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                MessageBox.Show("Added OK!");
            }
        }

        public string getItemName()
        {
            return itemNameBox.Text;
        }

        public string getItemPrice()
        {
            return itemPriceBox.Text;
        }

        public string getItemCategoryType()
        {
            return itemTypeBox.SelectedItem.ToString();
        }

        public bool validate()
        {
            Regex priceValidate = new Regex(@"^[0-9]");

            errorProvider.Clear();

            if (string.IsNullOrEmpty(itemNameBox.Text))
            {
                errorProvider.SetError(itemNameBox, "Only Allow Numberic Values!");
                return false;
            }

            if (!priceValidate.IsMatch(itemPriceBox.Text) || string.IsNullOrEmpty(itemPriceBox.Text))
            {
                errorProvider.SetError(itemPriceBox, "Only Allow Numberic Values!");
                return false;
            }

            if(itemTypeBox.SelectedItem == null)
            {
                errorProvider.SetError(itemTypeBox, "Only Allow Numberic Values!");
                return false;
            }

            return true;
        }
    }
}
