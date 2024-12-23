using System;
using System.Collections.Generic;

public class Order
{
   
    private List<Product> _products;
    private Customer _customer;

   
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    )
    public decimal CalculateTotalCost()
    {
        decimal total = 0;

        foreach (Product product in products)
        {
            total += product.TotalCost();
        }

        n
        total += customer.IsInUSA() ? 5 : 35;

        return total;
    }

   
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    
    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        return label;
    }
}
