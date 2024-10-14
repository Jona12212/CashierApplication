using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemNamespace
{
    public partial class Form1 : Form
    {
        private DiscountedItem discountedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get item details from input fields
                string name = tb_item.Text;
                double price = Convert.ToDouble(tb_price.Text);
                int quantity = Convert.ToInt32(tb_quantity.Text);
                double discount = Convert.ToDouble(tb_discount.Text);

                // Create DiscountedItem object and calculate total price
                discountedItem = new DiscountedItem(name, price, quantity, discount);
                double totalPrice = discountedItem.getTotalPrice();

                // Display total price
                tb_totalAmount.Text = totalPrice.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for price, quantity, and discount.", "Input Error");
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that the total price has been calculated first
                if (discountedItem != null)
                {
                    // Get the payment amount
                    double paymentAmount = Convert.ToDouble(tb_paymentReceived.Text);

                    // Set the payment amount and calculate the change
                    discountedItem.setPayment(paymentAmount);
                    double change = discountedItem.getChange();

                    // Display the change
                    tb_change.Text = change.ToString("F2");

                    // Show a message with the change
                    MessageBox.Show("Change: " + change.ToString("F2"));
                }
                else
                {
                    MessageBox.Show("Please calculate the total price before submitting payment.", "Error");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Input Error");
            }
        }
    }
}