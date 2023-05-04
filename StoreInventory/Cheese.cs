namespace Store;
public class Cheese : DairyProduct
{
    int age;
    public Cheese(){
        Console.Clear();
                Console.Write("Type the name of the product: ");
                name = Console.ReadLine();
                Console.Write("\nType the price you wish to sell it at: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("\nType the productID: ");
                productID = int.Parse(Console.ReadLine());
                Console.Write("\nType the age of the cheese: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("\nType the percentage of fat in the product: ");
                percentFat = double.Parse(Console.ReadLine());
    }

    public override string Print()
    {
        return $"Name: {name}, Price: {price} SEK, ProductID: {productID}, Age: aged {age} years, Percent fat: {percentFat}%";
    }
}