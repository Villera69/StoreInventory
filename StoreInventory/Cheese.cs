namespace Store;
public class Cheese : DairyProduct
{
    protected int age;
    public Cheese(double price, int productID, String name, int age){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.age = age;
    }
}