using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Product product;
        List<Order> orders = new List<Order> ();


        /* 1st Order */
        Order order1 = new Order("Brenden Lyon", "my address", "Houston", "Texas", "USA");
        product = new Product("Food1", 1, 11.50, 20);
        order1.AddProduct(product);

        product = new Product("Food 2", 2, 20, 1);
        order1.AddProduct(product);

        product = new Product("Food 3", 3, 3.50, 12);
        order1.AddProduct(product);

        orders.Add(order1);
        
        /* 2nd Order */
        Order order2 = new Order("Iron Man", "10880 Malibu Point", "Malibu", "California", "United States");
        product = new Product("Oranges", 1, 5.95, 32);
        order2.AddProduct(product);

        product = new Product("Car Battery", 2, 150.32, 25);
        order2.AddProduct(product);

        product = new Product("Juice", 3, 5.93, 5);
        order2.AddProduct(product);

        product = new Product("Lemons", 4, 2.43, 8);
        order2.AddProduct(product);

        product = new Product("Sugar", 3, 4.33, 2);
        order2.AddProduct(product);

        orders.Add(order2);

        foreach(Order order in orders)
        {
            Console.WriteLine("/**** ORDER ****/");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"\nShipping Price: ${order.ShippingCost()}");
            Console.WriteLine($"Total Price: ${order.TotalPrice()}\n");
        }

    }
}