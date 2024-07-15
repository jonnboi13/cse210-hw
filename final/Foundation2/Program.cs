using System;

class Program
{
    static void Main()
    {
        // Create an address
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create a customer
        Customer customer = new Customer("John Doe", address);

        // Create some products
        Product product1 = new Product("Laptop", "LPT123", 999.99, 1);
        Product product2 = new Product("Mouse", "MSE456", 25.50, 2);

        // Create an order
        Order order = new Order(customer);

        // Add products to the order
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display packing label
        Console.WriteLine(order.GetPackingLabel());

        // Display shipping label
        Console.WriteLine(order.GetShippingLabel());

        // Check if shipping to USA
        if (order.IsShippingToUSA())
        {
            Console.WriteLine("The order is being shipped within the USA.");
        }
        else
        {
            Console.WriteLine("The order is being shipped internationally.");
        }

        // Display total cost
        Console.WriteLine("Total Cost: $" + order.CalculateTotalCost());
    }
}
