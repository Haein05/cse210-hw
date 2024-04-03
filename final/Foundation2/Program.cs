using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("500 Park Ave", "New York", "NY", "USA");
        Customer customer1 = new Customer("Emily Johnson", address1);
        List<Product> products1 = new List<Product>()
        {
        new Product("banana", "B789", 9.99, 3),
        new Product("bread", "B234", 6.99, 1)
        };
        Order order1 = new Order(products1, customer1);



        Address address2 = new Address("250 Maple St", "London", "LN", "UK");
        Customer customer2 = new Customer("John Smith", address2);
        List<Product> products2 = new List<Product>()
        {
        new Product("Chocolate Bar", "C321", 7.99, 2),
        new Product("Coffee Beans", "C654", 14.99, 1),
        new Product("Tea Leaves", "T987", 12.99, 4)
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

