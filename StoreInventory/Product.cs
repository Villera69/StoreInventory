namespace Store;
public abstract class Product
{
    protected String name;
    protected long productID;

    protected double price;

    public long GetID(){
        return productID;
    }
    public void SetPrice(double newPrice){
        price = newPrice;
    }
    public static long UnixTimeNow()
    {
        var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
        return (long)timeSpan.TotalSeconds;
    }

    public abstract String Print();

    public virtual void AddValuesToParameters(){
        bool containsInt = true;
        bool isDouble = false;
        productID = UnixTimeNow();
        do
        {
            Console.Write("Type the name of the product: ");
            name = Console.ReadLine();
            if (name.Length > 0)
            {
                containsInt = name.Any(char.IsDigit);
            }

            if(containsInt){
                Console.WriteLine("\nYou need to write a name with at least 1 letter, and it should not contain any digits. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (containsInt);
        do
        {
            Console.Write("\nType the price you wish to sell it at: ");
            isDouble = double.TryParse(Console.ReadLine(), out price);
            if(!isDouble){
                Console.WriteLine("\nInput the price using only numbers and a maximum of 2 decimal points. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isDouble);
    }

}