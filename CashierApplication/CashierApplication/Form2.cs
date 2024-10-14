using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class Form2 : Form
    {
        private Cashier cashier;
        public Form2()
        {
            InitializeComponent();
            cashier = new Cashier("Clarisa Castro", "Finance", "cashier101", "password123");
        }
    

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            // Validate login credentials
            if (cashier.validateLogin(username, password))
            {
                // Close the login form
                this.Hide();

                // Show frmPurchaseDiscountedItem form
                Form purchaseForm = new Form(cashier.getFullName(),
                                             cashier.getDepartment());
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Error");
            }
        }
    }
}
