class Product{

    private string kg_name;
    private string kg_productId;
    private double kg_price;
    private int kg_quantity;



    public Product(string name, string productId, double price, int quantity)
    {
        this.kg_name = name;
        this.kg_productId = productId;
        this.kg_price = price;
        this.kg_quantity = quantity;
    }
    public string getname(){

        return kg_name;
    }

    public string getproductId(){

        return kg_productId;
    }

    public double getprice(){

        return kg_price * kg_quantity;
    }

    public int getquantity(){
        return  kg_quantity;
    }
}