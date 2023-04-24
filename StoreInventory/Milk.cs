namespace Store;

public class Milk : DairyProduct
{
    protected MilkType milkType;
    public Milk(double price, int productID, String name, MilkType milkType){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.milkType = milkType;
    }
}

public enum MilkType
{
    Skimmed,
    Reduced,
    Whole,
}