namespace Store;

public class Milk : DairyProduct
{
    MilkType milkType;
    public Milk(){
        Console.Clear();
        String choice;
        bool fail = true;
        AddValuesToParameters();
        do
        {
            Console.Clear();
            Console.WriteLine("\nWhat type of milk you wish to add? ");
            Console.WriteLine("(1) Skimmed");
            Console.WriteLine("(2) Reduced");
            Console.WriteLine("(3) Whole");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    milkType = MilkType.Skimmed;
                    fail = false;
                    break;
                case "2":
                    milkType = MilkType.Reduced;
                    fail = false;
                    break;
                case "3":
                    milkType = MilkType.Whole;
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
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {milkType} milk, Percent Fat: {percentFat}%";
    }
}

public enum MilkType
{
    Skimmed,
    Reduced,
    Whole,
}