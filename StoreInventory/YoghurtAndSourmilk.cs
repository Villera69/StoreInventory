namespace Store;
public class YoghurtAndSourmilk : DairyProduct
{
    protected Taste taste;
    public YoghurtAndSourmilk(double price, int productID, String name, Taste taste){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.taste = taste;
    }
}

public enum Taste
{
    Neutral,
    Vanilla,
    Strawberry,
    Blueberry,
    Raspberry,

}