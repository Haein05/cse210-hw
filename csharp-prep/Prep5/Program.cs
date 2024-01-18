using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        // Fuctions

        //returnType FuctionName(papramType parpamName1, paramType paramName2)
        // {
        //    fuction body
        // }

        // return int
        int Add2(int number, string name) {
            return number + 2;
        }

        // void
        void PrintName(string name) {
            System.Console.WriteLine(name);
        }

        int answer = Add2(10, "bob");
        PrintName($"Bob is {answer}");

        // use static for functions (for now)

        //varible scope
        var i = 12;
        {
            var y = 10;
            y = i + 3;
            i = y + 4;
        }
       
       DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}