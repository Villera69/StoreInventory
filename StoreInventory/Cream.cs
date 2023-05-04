namespace Store;
public class Cream : DairyProduct
{
    Useage useage;
    public Cream(){
        String choice;
        Boolean fail = true;
        Console.Clear();
        Console.Write("Type the name of the product: ");
        name = Console.ReadLine();
        Console.Write("\nType the price you wish to sell it at: ");
        price = double.Parse(Console.ReadLine());
        Console.Write("\nType the productID: ");
        productID = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("\nWhat type of cream you wish to add? ");
            Console.WriteLine("(1) Cooking cream");
            Console.WriteLine("(2) Whipping cream");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    useage = Useage.Cooking;
                    percentFat = 0.5;
                    fail = false;
                    break;
                case "2":
                    useage = Useage.Whipping;
                    percentFat = 1.5;
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
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {useage} cream, Percent Fat: {percentFat}%";
    }
}

public enum Useage
{
    Cooking,
    Whipping,
}