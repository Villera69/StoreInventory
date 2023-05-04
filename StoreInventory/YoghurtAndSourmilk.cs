namespace Store;
public class YoghurtAndSourmilk : DairyProduct
{
    protected Taste taste;
    public YoghurtAndSourmilk(){
        String choice;
        Boolean fail = true;
        Console.Clear();
        Console.Write("Type the name of the product: ");
        name = Console.ReadLine();
        Console.Write("\nType the price you wish to sell it at: ");
        price = double.Parse(Console.ReadLine());
        Console.Write("\nType the productID: ");
        productID = int.Parse(Console.ReadLine());
        Console.Write("\nType the percentage of fat in the product: ");
        percentFat = double.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("\nWhat taste does the product that you wish to add have? ");
            Console.WriteLine("(1) Neutral");
            Console.WriteLine("(2) Vanilla");
            Console.WriteLine("(3) Strawberry");
            Console.WriteLine("(4) Blueberry");
            Console.WriteLine("(5) Raspberry");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    taste = Taste.Neutral;
                    fail = false;
                    break;
                case "2":
                    taste = Taste.Vanilla;
                    fail = false;
                    break;
                case "3":
                    taste = Taste.Strawberry;
                    fail = false;
                    break;
                case "4":
                    taste = Taste.Blueberry;
                    fail = false;
                    break;
                case "5":
                    taste = Taste.Raspberry;
                    fail = false;
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }while (fail);
    }

     public override string Print()
    {
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Taste: {taste}, Percent Fat: {percentFat}%";
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