namespace Store;
public class Butter : DairyProduct
{
    protected Saltiness saltiness;
    public Butter(double price, int productID, String name, Saltiness saltiness){
        this.price = price;
        this.productID = productID;
        this.name = name;
        this.saltiness = saltiness;
    }
}

public enum Saltiness
{
    Unsalted,
    Salted,
    ExtraSalted,
}