using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("Modern Art","Exploring the evolution of art styles",DateTime.Now,TimeSpan.FromDays(2), new Address("267 S 2nd E","Rexurg","Idaho",83440),"Haein",19,"Art History");
        lectures.Details();

        Receptions receptions = new Receptions("Wine Tasting","Exploring the world of fine wines",DateTime.Now,TimeSpan.FromDays(4), new Address("456 Vineyard Ln", "Napa", "CA", 94558),"wine_lover@example.com");
        lectures.Details();

        Outdoor outdoor = new Outdoor("Community Picnic","A fun day out for the whole family",DateTime.Now,TimeSpan.FromDays(6), new Address("789 Park Ave", "Los Angeles", "CA", 90001),"Partly Cloudy");
        lectures.Details();
    }
}