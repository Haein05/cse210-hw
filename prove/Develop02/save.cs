using System;

public class Save
{
    public void _save(List<Entry>entries){
        Console.WriteLine("Please entry your file name: ");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries){
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry}");

            }
            // Add text to a file using the WriteLine method
            
        }

    }

}