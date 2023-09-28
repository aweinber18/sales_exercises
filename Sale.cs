using System;

public class Sale
{
    public Sale(string item, string customer, double pricePerItem, int quantity, string address, bool expeditedShipping)
    {
        Item = item;
        Customer = customer;
        PricePerItem = pricePerItem;
        Quantity = quantity;
        Address = address;
        ExpeditedShipping = expeditedShipping;
    }
    public String Item { get; set; }
    public String Customer { get; set; }
    public double PricePerItem { get; set; }
    public int Quantity { get; set; }
    public String Address { get; set; }
    public bool ExpeditedShipping { get; set; }
}

