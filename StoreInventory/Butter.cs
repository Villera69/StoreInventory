namespace Store;
public class Butter : DairyProduct //Klassen för produkttypen butter, subklass av både dairyproduct och product
{
    Saltiness saltiness;
    public Butter(){    //Konstruktor för butter. Här sätts alla värdena.
        Console.Clear();
        bool fail = true;
        AddValuesToAttributes();    // denhär fixar allt generiskt, såsom produkt ID, namn, pris och fetthalt
        do  //här sätts värdet för den butter-specifika attributen saltiness.
        {
            Console.Clear();
            Console.WriteLine("\nHow salty is the butter? ");
            Console.WriteLine("(1) Unsalted");
            Console.WriteLine("(2) Salted");
            Console.WriteLine("(3) Extra salted");
            switch(Console.ReadLine())
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

     public override string Print() //Denhär används för att skriva ut produktens alla värden.
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {saltiness}, Percent Fat: {percentFat}%";
    }
}

public enum Saltiness //Enumeration för saltiness.
{
    Unsalted,
    Salted,
    ExtraSalted,
}