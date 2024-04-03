public class Lectures:Event
{
    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity,string name): base(title, description, date, time, address, speaker + ", " + capacity, name) {

      name = "Lectures";
    }

    public override void Details()
   {
     Console.WriteLine($"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}");
   }

}