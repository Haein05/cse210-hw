using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //while loop
        // int count = 0;
       // while (count < 5) 
        //{
            //System.Console.WriteLine($"count = {count}");
            // count = count + 1;
            // count += 1;
            // count++;
            //++count;

       // }

        //do-while loop
        //int moreCount = 0;
        //do {
            //System.Console.WriteLine($"moreCount = {moreCount++}");

        //} while(moreCount < 5);

        // for loop
        //for(var i=0; i<5; ++i) {
            //System.Console.WriteLine($"i = {i}");
        //}

        //System.Console.WriteLine($"i = {i}"); // won't work

        /// Assignment: Guess My Number
        /// Ask for random number
        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);

        //int guess;
        //do {
        /// Ask for user guess
        //System.Console.Write("Guess a number (between 1-10) ");
        //int guess = int.Parse(Console.ReadLine());

        /// Check if guess is higher
        //if (guess > random) {
            //System.Console.WriteLine("Too High");
        //}

        //else if(guess < random) 
        //{ /// Check if guess is lower
            //System.Console.WriteLine("Too Low");
        //}
        //else{ /// Check if guess is match
            //System.Console.WriteLine("Correct");
        //}
        //} while (random != guess);
        /// keep going...
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    

    }
}