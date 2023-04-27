namespace Store;
public abstract class DairyProduct : Product
{
    protected double percentFat;
    public DairyProduct(){}

    public override abstract String Print();
}