namespace Store;

public class Milk : DairyProduct
{
    MilkType milkType;
    public Milk(){
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
            Console.WriteLine("\nWhat type of milk you wish to add? ");
            Console.WriteLine("(1) Skimmed");
            Console.WriteLine("(2) Reduced");
            Console.WriteLine("(3) Whole");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    milkType = MilkType.Skimmed;
                    percentFat = 0.5;
                    fail = false;
                    break;
                case "2":
                    milkType = MilkType.Reduced;
                    percentFat = 1.5;
                    fail = false;
                    break;
                case "3":
                    milkType = MilkType.Whole;
                    percentFat = 3.0;
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
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {milkType} milk, Percent Fat: {percentFat}%";
    }
}

public enum MilkType
{
    Skimmed,
    Reduced,
    Whole,
}