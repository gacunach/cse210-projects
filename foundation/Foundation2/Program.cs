using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple St", "Toronto", "Ontario", "Canada");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        Product product1 = new Product("Laptop", "123", 1000m, 1);
        Product product2 = new Product("Mouse", "456", 25m, 2);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}");

       
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

    
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");
    }
}
