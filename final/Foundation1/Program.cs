using System;

class Program
{
    static void Main(string[] args)
    {

        
        List<Video> videos = new List<Video>{
        new Video("How to Drink Water Efficiently", "Jane Doe", 120000),
        new Video("Top 10 Tech Companies in 2024", "John Smith", 500000),
        new Video("Mastering Song Memorization Techniques", "Alex Johnson", 750000)
        };

        foreach (Video video in videos){
            
            video.display();
        }
        

        



    }
}