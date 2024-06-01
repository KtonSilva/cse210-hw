using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "LAP123", 999.99, 1);
        Product product2 = new Product("Mouse", "MOU456", 19.99, 2);
        Product product3 = new Product("Keyboard", "KEY789", 49.99, 1);
        Product product4 = new Product("Monitor", "MON012", 199.99, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order information
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Order for customer: " + order.Customer.Name);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Total Cost: $" + order.CalculateTotalCost());
        Console.WriteLine();
    }
}
