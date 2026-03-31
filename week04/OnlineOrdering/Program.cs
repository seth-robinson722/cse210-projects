using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Order 1 (USA Address) ---
            Address address1 = new Address("123 Maple St", "Carrollton", "TX", "USA");
            Customer customer1 = new Customer("Seth Robinson", address1);
            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Mechanical Keyboard", "KBD-101", 89.99, 1));
            order1.AddProduct(new Product("USB-C Cable", "CAB-500", 12.50, 2));

            // --- Order 2 (International Address) ---
            Address address2 = new Address("456 Sakura Rd", "Tokyo", "Tokyo", "Japan");
            Customer customer2 = new Customer("Hiroshi Tanaka", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("Leather Journal", "BOK-202", 25.00, 3));
            order2.AddProduct(new Product("Fountain Pen", "PEN-303", 45.00, 1));
            order2.AddProduct(new Product("Ink Bottle", "INK-99", 15.75, 1));

            // Display Order 1
            DisplayOrderResults(order1);

            // Display Order 2
            DisplayOrderResults(order2);
        }

        static void DisplayOrderResults(Order order)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}");
            Console.WriteLine("========================================\n");
        }
    }
}