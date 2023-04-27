namespace Store;

public class Milk : DairyProduct
{
    MilkType milkType;
    public Milk(double price, int productID, String name, MilkType milkType, double percentFat){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.milkType = milkType;
        this.percentFat = percentFat;
    }

    public override string Print()
    {
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {milkType} milk, Percent Fat: {percentFat}%";
    }
}

public enum MilkType
{
    Skimmed,
    Reduced,
    Whole,
}