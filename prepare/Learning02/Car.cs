namespace Learning02;

class Car 

{
    public string model;
    public string make;
    public int year;
    public int milesPerGallen;
    public int gallons;
    public Person owner;

    public Car(string make, string model, int milesPerGallen, int gallons) {
        this.model = model;
        this.make = make;
        this.milesPerGallen = milesPerGallen;
        this.gallons = gallons;
    }


    public int TotalRange() 
    {
        return gallons * milesPerGallen;
    }

    public void Dispaly() {
        System.Console.WriteLine($"{make} {model} {year} : totalRange = {TotalRange()}");
    }
}

class Person{
    public string name;
    public string phone;

    public string DisplayString(){
        return $"{name} {phone}";
    }
}