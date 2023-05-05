namespace Store;
public class YoghurtAndSourmilk : DairyProduct  //Klassen för produkttypen yoghurt and sourmilk, subklass av både dairyproduct och product
{
    protected Taste taste;
    public YoghurtAndSourmilk(){     //Konstruktor för yoghurt and sourmilk. Här sätts alla värdena.
        String choice;
        bool fail = true;
        AddValuesToParameters();    // denhär fixar allt generiskt, såsom produkt ID, namn, pris och fetthalt
        do  //här sätts värdet för den yoghurt and sourmilk-specifika attributen taste.
        {
            Console.Clear();
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

     public override string Print() //Denhär används för att skriva ut produktens alla värden.
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Taste: {taste}, Percent Fat: {percentFat}%";
    }
}

public enum Taste   //Enumeration för useage
{
    Neutral,
    Vanilla,
    Strawberry,
    Blueberry,
    Raspberry,

}