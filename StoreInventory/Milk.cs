namespace Store;

public class Milk : DairyProduct    //Klassen för produkttypen milk, subklass av både dairyproduct och product
{
    MilkType milkType;
    public Milk(){  //Konstruktor för milk. Här sätts alla värdena.
        Console.Clear();
        bool fail = true;
        AddValuesToParameters();    // denhär fixar allt generiskt, såsom produkt ID, namn, pris och fetthalt
        do  //här sätts värdet för den milk-specifika attributen milk type.
        {
            Console.Clear();
            Console.WriteLine("\nWhat type of milk you wish to add? ");
            Console.WriteLine("(1) Skimmed");
            Console.WriteLine("(2) Reduced");
            Console.WriteLine("(3) Whole");
            switch(Console.ReadLine())
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

    public override string Print() //Denhär används för att skriva ut produktens alla värden.
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {milkType} milk, Percent Fat: {percentFat}%";
    }
}

public enum MilkType    //Enumeration för milk type
{
    Skimmed,
    Reduced,
    Whole,
}