namespace Store;
public class Cream : DairyProduct  //Klassen för produkttypen cream, subklass av både dairyproduct och product
{
    Useage useage;
    public Cream(){     //Konstruktor för cream. Här sätts alla värdena.
        Console.Clear();
        bool fail = true;
        AddValuesToParameters();    // denhär fixar allt generiskt, såsom produkt ID, namn, pris och fetthalt
        do  //här sätts värdet för den cream-specifika attributen useage.
        {
            Console.Clear();
            Console.WriteLine("\nWhat type of cream you wish to add? ");
            Console.WriteLine("(1) Cooking cream");
            Console.WriteLine("(2) Whipping cream");
            switch(Console.ReadLine())
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

     public override string Print() //Denhär används för att skriva ut produktens alla värden.
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Type: {useage} cream, Percent Fat: {percentFat}%";
    }
}

public enum Useage  //Enumeration för useage
{
    Cooking,
    Whipping,
}