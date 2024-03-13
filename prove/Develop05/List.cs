using System;
using System.Collections.Generic;

public class List
{
    public List<Goals> MenuList = new List<Goals>();
    string menuinput;

    private int totalPoint = 0;

    // Property to access total points
    public int Pointnumber
    {
        get { return totalPoint; }
        set { totalPoint = value; }
    }

    public void Menu()
    {
        while (menuinput != "4")
        {
            Console.WriteLine("------------------------\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal\n------------------------");

            Console.WriteLine("Which type of goal would you like to create?");

            menuinput = Console.ReadLine();

            string goalname;
            string goaltype;
            int goalpoint;
            int goaltimes = 0;
            int Bonus;

            switch (menuinput)
            {
                case "1":
                    Console.WriteLine("Please enter the goal name: ");
                    goalname = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    goaltype = Console.ReadLine();
                    goalpoint = ReadIntFromConsole("What is the amount of points associated with this goal?");
                    Simple simple = new Simple(goalname, goaltype, goalpoint, false);
                    MenuList.Add(simple);
                    return;

                case "2":
                    Console.WriteLine("Please enter the goal name: ");
                    goalname = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    goaltype = Console.ReadLine();
                    goalpoint = ReadIntFromConsole("What is the amount of points associated with this goal?");
                    Eternal eternal = new Eternal(goalname, goaltype, goalpoint);
                    MenuList.Add(eternal);
                    return;

                case "3":
                    Console.WriteLine("What's the name of your goal? ");
                    goalname = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    goaltype = Console.ReadLine();
                    goalpoint = ReadIntFromConsole("What is the amount of points associated with this goal?");
                    goaltimes = ReadIntFromConsole("How many times does this goal need to be accomplished for a bonus?");
                    Bonus = ReadIntFromConsole("What is the bonus for accomplishing it that many times?");
                    Checklist checklist = new Checklist(goalname, goaltype, goalpoint, 0, goaltimes, Bonus);
                    MenuList.Add(checklist);
                    return;
            }
        }
    }

    // Method to read an integer value from the console with error handling
    private int ReadIntFromConsole(string message)
    {
        int result;
        bool validInput = false;

        do
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            validInput = int.TryParse(input, out result);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!validInput);

        return result;
    }

    public void DisplayGoals()
    {
        Console.WriteLine(MenuList.Count);
        int i = 1;
        foreach (Goals l in MenuList)
        {
            l.Display(i);
            i++;
        }
    }
}