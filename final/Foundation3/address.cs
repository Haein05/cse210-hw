public class Address
{
    private string kg_street;
    private string kg_city;
    private string kg_state;
    private int kg_zip;

    public Address(string street, string city, string state, int zip) {
        this.kg_street = street;
        this.kg_city = city;
        this.kg_state = state;
        this.kg_zip = zip;
    }

    public string GetAddress() {
        return $"{kg_street}, {kg_city}, {kg_state} {kg_zip}";
    }
}
