using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Wireless Mouse", "M100", 29.99, 2);
        Product product2 = new Product("Mechanical Keyboard", "K200", 89.50, 1);

        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);

        List<Product> productsOrder1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productsOrder1, customer1);

        Product product3 = new Product("Laptop Stand", "L300", 49.90, 1);
        Product product4 = new Product("USB-C Hub", "U400", 39.95, 1);
        Product product5 = new Product("Bluetooth Speaker", "B500", 79.00, 1);

        Address address2 = new Address("10 Downing Street", "London", "Greater London", "United Kingdom");
        Customer customer2 = new Customer("James Bond", address2);

        List<Product> productsOrder2 = new List<Product> { product3, product4, product5 };
        Order order2 = new Order(productsOrder2, customer2);


        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetCostOrder():F2}\n");

        // Display order 2
        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetCostOrder():F2}\n");
        
        
        
    }
}