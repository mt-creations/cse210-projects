using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        //first order

        Address address1 = new Address("5432 Orange St.", "Anaheim", "CA", "USA");

        Customer customer1 = new Customer("Emily Thomas", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Dance Shoes", "D364", 74.99m, 2));
        order1.AddProduct(new Product("Color guard flag carry bag", "C998", 49.99m, 1));
        order1.AddProduct(new Product("Rifle tape white", "T153", 7.99m, 3));
        orders.Add(order1);

        //second order

        Address address2 = new Address("6543 Shady view ln.", "Ciudad Juarez", "Chihuahua", "Mexico");

        Customer customer2 = new Customer("Emilio Jimenez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Blue Jeans", "B178", 63.99m, 2));
        order2.AddProduct(new Product("Stripe tee black", "S098", 19.99m, 1));
        order2.AddProduct(new Product("Mens hoodie navy", "H765", 47.99m, 1));
        orders.Add(order2);
        
        foreach (Order order in orders)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }   

    }
}