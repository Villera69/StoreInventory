namespace Store;
public class Cheese : DairyProduct //Klassen för produkttypen cheese, subklass av både dairyproduct och product
{
    int age;
    public Cheese(){    //Konstruktor för butter. Här sätts alla värdena.
        Console.Clear();
        bool isInt;
        AddValuesToAttributes();    // denhär fixar allt generiskt, såsom produkt ID, namn, pris och fetthalt
        do  //här sätts värdet för den cheese-specifika attributen age.
        {
            Console.Clear();
            Console.Write("\nType the age of the cheese in months: ");
            isInt = int.TryParse(Console.ReadLine(), out age);
            if(age <= 0){
                isInt = false;
            }
            if(!isInt){
                Console.WriteLine("Input the age as a positive integer. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isInt);
    }

    public override string Print() //Denhär används för att skriva ut produktens alla värden.
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Age: aged {age} months, Percent fat: {percentFat}%";
    }
}