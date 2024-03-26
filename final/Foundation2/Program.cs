using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        // Product product = new Product("milk" , 120, (decimal) 3.12 , 2);
        // Address address = new Address("340 s 100 w", "Rexburg", "ID", "Canada");

        Address address1 = new Address("300 Main St", "San Jose", "CA", "USA");
        Customer customer1 = new Customer("Kyle Smith", address1);
        List<Product> products1 = new List<Product>()
        {
            new Product("apple", "A123", 9.99, 3),
            new Product("milk", "M456", 6.99, 1)
        };
        Order order1 = new Order(products1, customer1);



        Address address2 = new Address("100 W 200 S", "Guangzhou", "GD", "China");
        Customer customer2 = new Customer("May Doe", address2);
        List<Product> products2 = new List<Product>()
        {
            new Product("Thingamajig", "T789", 7.99, 2),
            new Product("Doohickey", "D012", 14.99, 1),
            new Product("Whatchamacallit", "W456", 12.99, 4)
        };
        Order order2 = new Order(products2,customer2);

        Console.WriteLine(order1.p_label());
        Console.WriteLine(order1.s_label());
        Console.WriteLine($"{order1.total():C}\n");

        Console.WriteLine(order2.p_label());
        Console.WriteLine(order2.s_label());
        Console.WriteLine($"{order2.total():C}\n");

        
        
    }
}

