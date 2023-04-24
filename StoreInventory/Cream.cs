namespace Store;
public class Cream : DairyProduct
{
    protected Useage useage;
    public Cream(double price, int productID, String name, Useage useage){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.useage = useage;
    }
}

public enum Useage
{
    Cooking,
    Whipping,
}