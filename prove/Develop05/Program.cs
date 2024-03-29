using System;

class Program
{
    static void Main(string[] args)
    {
        string userinput = "";
        List list = new List();
        SaveLoad saveload = new SaveLoad();

        while (userinput != "6")
        {
            Console.WriteLine($"Points: {list.Pointnumber}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a number from the menu: ");

            userinput = Console.ReadLine();

            if (userinput == "1")
            {
                list.Menu();
            }
            else if (userinput == "2")
            {
                list.DisplayGoals();
            }
            else if (userinput == "3")
            {
                saveload._save(list.MenuList);
            }
            else if (userinput == "4")
            {
                saveload._load(list.MenuList);
            }
            else if (userinput == "5")
            {
                list.DisplayGoals();
                Console.Write("Which one? ");
                string choice = Console.ReadLine();
                int selectedIndex = int.Parse(choice) - 1;

                if (selectedIndex >= 0 && selectedIndex < list.MenuList.Count)
                {
                    list.Pointnumber += list.MenuList[selectedIndex].CompletedGoals();
                    Console.WriteLine($"You have {list.Pointnumber} points");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}