using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("ONLINE ORDERING PROGRAM");
        Console.WriteLine("--------------------------------"); // Separator

        // Order 1 (Chile)
        Console.WriteLine("ORDER 1");
        Address address1 = new Address("2595 René Quevedo", "Villa Alemana", "Valparaíso", "Chile");
        Customer customer1 = new Customer("Meilhyn Zamudio", address1);
        Product product1 = new Product("Blush", "ACC001", 6.00f, 1);
        Product product2 = new Product("Eye Shadow", "ACC002", 10.99f, 1);
        Product product3 = new Product("Make-up bag", "ACC003", 25.00f, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine("--------------------------------"); // Separator

        // Order 2 (USA)
        Console.WriteLine("ORDER 2");
        Address address2 = new Address("Hickory Lane", "Smallville", "Kansas", "USA");
        Customer customer2 = new Customer("Martha Kent", address2);
        Product product4 = new Product("Blush", "ACC001", 6.00f, 1);
        Product product5 = new Product("Eye Shadow", "ACC002", 10.99f, 1);
        Product product6 = new Product("Make-up bag", "ACC003", 25.00f, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine("--------------------------------"); // Separator
    }
}