namespace Store;
public class Butter : DairyProduct
{
    Saltiness saltiness;
    public Butter(double price, int productID, String name, Saltiness saltiness, double percentFat){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.saltiness = saltiness;
        this.percentFat = percentFat;
    }

     public override string Print()
    {
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {saltiness}, Percent Fat: {percentFat}%";
    }
}

public enum Saltiness
{
    Unsalted,
    Salted,
    ExtraSalted,
}