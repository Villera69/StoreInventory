namespace Store;
public class Cream : DairyProduct
{
    Useage useage;
    public Cream(double price, int productID, String name, Useage useage, double percentFat){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.useage = useage;
        this.percentFat = percentFat;
    }

     public override string Print()
    {
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {useage} cream, Percent Fat: {percentFat}%";
    }
}

public enum Useage
{
    Cooking,
    Whipping,
}