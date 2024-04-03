public class Outdoor:Event
{
    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address,weather,"Outdoor") {
     
    }

    public override void Details()
   {
    Console.WriteLine($"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{kg_additionalInfo}");
   }
}
