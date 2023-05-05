namespace Store;
public class Butter : DairyProduct
{
    Saltiness saltiness;
    public Butter(){
        Console.Clear();
        String choice;
        bool fail = true;
        AddValuesToParameters();
        do
        {
            Console.WriteLine("\nHow salty is the butter? ");
            Console.WriteLine("(1) Unsalted");
            Console.WriteLine("(2) Salted");
            Console.WriteLine("(3) Extra salted");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    saltiness = Saltiness.Unsalted;
                    fail = false;
                    break;
                case "2":
                    saltiness = Saltiness.Salted;
                    fail = false;
                    break;
                case "3":
                    saltiness = Saltiness.ExtraSalted;
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
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {saltiness}, Percent Fat: {percentFat}%";
    }
}

public enum Saltiness
{
    Unsalted,
    Salted,
    ExtraSalted,
}