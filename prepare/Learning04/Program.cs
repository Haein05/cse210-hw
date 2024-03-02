using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

//Person
class Person {
    private string id;
    private string name;

    public Person(string id, string name) {
        this.id = id;
        this.name = name;
    }

    public void display()
    {
        System.Console.WriteLine($"{name}: {id}");
    }
}
// Student
class Student : Person{
    private string major;
    public Student(string id, string name, string majoir) : base(id, name) {
        this.major = majoir;
    }
    public void display()
    {
        System.Console.WriteLine($"{name}: {id}");
    }
}
