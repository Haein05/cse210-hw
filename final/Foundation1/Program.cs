using System;

class Program
{
    static void Main(string[] args)
    {

        
        List<Video> videos = new List<Video>{
        new Video("how to dring water", "Haein Lee", 143200432),
        new Video("Top 10 companies", "Mallory Lee", 33256),
        new Video("The best way to memorize a song", "Danny Kim", 4654777)
        };

        foreach (Video video in videos){
            
            video.display();
        }
        

        



    }
}