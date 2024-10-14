using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
     public class Item
    { 
    // Private Fields
        protected string item_name;
    protected double item_price;
    protected int item_quantity;
    protected double total_price;

    // Constructor
    public Item(string name, double price, int quantity)
    {
        item_name = name;
        item_price = price;
        item_quantity = quantity;
    }

    // Method to get total price
    public virtual double getTotalPrice()
    {
        total_price = item_price * item_quantity;
        return total_price;
    }

    // Method to set payment (can be used by subclasses)
    public virtual void setPayment(double amount)
    {
        // Placeholder for future implementation
    }
}

public class DiscountedItem : Item
{
    // Fields for DiscountedItem
    private double item_discount;
    private double discounted_price;
    private double payment_amount;
    private double change;

    public DiscountedItem(string name, double price, int quantity, double discount)
       : base(name, price, quantity)
    {
        item_discount = discount;
    }

    // Compute discounted total price
    public override double getTotalPrice()
    {
        double discountFactor = item_discount * 0.01;  // Convert discount to percentage
        discounted_price = item_price * (1 - discountFactor);  // Discounted price
        total_price = discounted_price * item_quantity;  // Total amount after discount
        return total_price;
    }

    // Method to set payment and compute change
    public override void setPayment(double amount)
    {
        payment_amount = amount;
        change = payment_amount - total_price;  // Compute change based on total price
    }

    // Method to get the change
    public double getChange()
    {
        return change;
    }
}
}