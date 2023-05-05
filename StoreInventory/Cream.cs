namespace Store;
public class Cream : DairyProduct
{
    Useage useage;
    public Cream(){
        Console.Clear();
        String choice;
        bool fail = true;
        AddValuesToParameters();
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
                    fail = false;
                    break;
                case "2":
                    useage = Useage.Whipping;
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
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {useage} cream, Percent Fat: {percentFat}%";
    }
}

public enum Useage
{
    Cooking,
    Whipping,
}