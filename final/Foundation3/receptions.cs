public class Receptions:Event
{
    public Receptions(string title, string description, DateTime date, TimeSpan time, Address address, string Email): base(title, description, date, time, address,Email,"Receptions") 
    {
 
    }
    public override void Details()
   {
    Console.WriteLine($"Title: {kg_title}\nDescription: {kg_description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{kg_additionalInfo}");
    
   }
}