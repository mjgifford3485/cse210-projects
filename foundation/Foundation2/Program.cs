using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("321 Fake St", "Fruita", "CO", "USA");
        Address address2 = new Address("855 New Way", "Beginnings", "SD", "USA");

        Customer customer1 = new Customer("Joe Bently", address1);
        Customer customer2 = new Customer("Erica Brody", address2);

        Product productA1 = new Product("Computer", 85, 499.99, 1);
        Product productA2 = new Product("Monitor", 89, 249.99, 2);

        Product productB1 = new Product("Couch", 1022, 369.99, 1);
        Product productB2 = new Product("Recliner", 1055, 149.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(productA1);
        order1.AddProduct(productA2);

        Order order2 = new Order(customer2);
        order2.AddProduct(productB1);
        order2.AddProduct(productB2);

        Console.WriteLine("Order 1: ");
        Console.WriteLine($"Total Cost: {order1.TotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel(address1, customer1));
        Console.WriteLine();
        Console.WriteLine("Order 2: ");
        Console.WriteLine($"Total Cost: {order2.TotalCost():f2}");
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel(address2, customer2));
    }
}