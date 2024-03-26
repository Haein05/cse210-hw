class Address{

    private string kg_street;
    private string kg_city;
    private string kg_state;
    private string kg_country;

    public Address(string street, string city, string state, string country){

        this.kg_street = street;
        this.kg_city = city;
        this.kg_state = state;
        this.kg_country = country;

    }

    public bool intheUSA(){

        return kg_country=="USA";
    }

    public string fulladdress(){

        return $"{kg_street}\n {kg_city}, {kg_state} {kg_country}";
    }
}
