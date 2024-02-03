using System;

public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    List<string> prompt = new List<string>(){
        "What are three things you're grateful for today, and why?",
        "How do you feel about the person you are becoming?",
        "What is one strength you possess that you would like to further develop?",
        "What is one thing you accomplished today that you're proud of?",
        "Reflect on any challenges you faced and how you overcame them.",
        "Reflect on the steps you can take today to move closer to your aspirations.",
        "What challenges are you currently facing, and how can you turn them into opportunities for growth?",
        "What inspires you, and how can you channel that inspiration into positive action?",
        "How have you taken care of yourself today, both physically and mentally?"

    };


    public void promptquestion(){
        
        int numberofpromt= prompt.Count;
        Random rnm = new Random();
        int rindex= rnm.Next(numberofpromt);
        _prompt = prompt[rindex];
        Console.WriteLine(_prompt);
        Console.WriteLine("Please enter your entry");
        _entry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        
    }


}

