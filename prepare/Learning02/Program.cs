using System;
using System.Buffers;

class Program
{
    static void Main(string[] args)
    {
        int count = 23;

        var cars = new List<Car>();

        var car = new Car();
        car.model = "Honda";
        car.model = "Civic";
        car.year =2021;
        car.gallons = 10;
        car.milesPerGallen = 30;

        var owner = new Person();
        owner.name = "bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car();
        car.model = "Ford";
        car.model = "F-150";
        car.gallons = 30;
        car.milesPerGallen = 5;

        owner = new Person();
        owner.name = "sue";
        owner.phone = "444-4444";
        car.owner = owner;


        cars.Add(car);

        Console.Clear();
        foreach(var c in cars) {
            //System.Console.WriteLine($"{c.make} {c.model}: totalRange = {c.TotalRange()}");
            c.Dispaly();
        }

         Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
