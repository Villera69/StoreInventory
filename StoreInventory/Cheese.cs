namespace Store;
public class Cheese : DairyProduct
{
    int age;
    public Cheese(){
        Console.Clear();
        bool isInt;
        AddValuesToParameters();

        do
        {
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

    public override string Print()
    {
        return $"[{productID}] Name: {name}, Price: {price} SEK, Age: aged {age} months, Percent fat: {percentFat}%";
    }
}