class Customer{

    private string kg_cname;
    
    private Address address;


    public Customer(string name, Address address)
    {
        this.kg_cname = name;
        this.address = address;
    }

    public string GetName()
    {
        return kg_cname;
    }
    public bool isinUSA(){
        return address.intheUSA();
    }

    public Address GetAddress()
    {
        return address;
    }
}