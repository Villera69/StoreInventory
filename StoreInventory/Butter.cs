namespace Store;
public class Butter : DairyProduct
{
    Saltiness saltiness;
    public Butter(){
        String choice;
        Boolean fail = true;
        Console.Clear();
        Console.Write("Type the name of the product: ");
        name = Console.ReadLine();
        Console.Write("\nType the price you wish to sell it at: ");
        price = double.Parse(Console.ReadLine());
        Console.Write("\nType the productID: ");
        productID = int.Parse(Console.ReadLine());
        Console.Write("\nType the percentage of fat in the product: ");
        percentFat = double.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("\nWhat level of salt does the product that you wish to add have? ");
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
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Type: {saltiness}, Percent Fat: {percentFat}%";
    }
}

public enum Saltiness
{
    Unsalted,
    Salted,
    ExtraSalted,
}