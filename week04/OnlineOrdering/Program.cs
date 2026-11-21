using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Customer and address in the USA (shipping is $5).
        Address address1 = new Address("123 Oak Street", "Boise", "Idaho", "USA");
        Customer customer1 = new Customer("Olivia Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 18.50, 2));
        order1.AddProduct(new Product("Keyboard", "KB-205", 32.00, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC-310", 7.25, 3));

        // Order 2: Customer outside the USA (shipping is $35).
        Address address2 = new Address("45 King Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Noah Williams", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS-410", 27.00, 1));
        order2.AddProduct(new Product("Headphones", "HP-520", 45.00, 2));

        // Store both orders in a list and display each order.
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("ORDER " + orderNumber);
            Console.WriteLine("========================================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine("Order total: $" + order.GetTotalCost().ToString("F2"));
            Console.WriteLine();

            orderNumber++;
        }
    }
}
