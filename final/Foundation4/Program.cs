using System;

class Program
{
    static void Main(string[] args)
    {  
        List<Activity> activity = new List<Activity>();

        RunningActivity  runningActivity = new RunningActivity(DateTime.Now,45, 7.5f);
        SwimmingActivity swimmingActivity = new SwimmingActivity (DateTime.Now,60, 20);
        CyclingActivity cyclingActivity = new CyclingActivity (DateTime.Now,120, 50);
        
        activity.Add(runningActivity);
        activity.Add(swimmingActivity);
        activity.Add(cyclingActivity);

        foreach (Activity a in activity)
        {
            Console.WriteLine(a.GetSummary());
        }

        
    }
}