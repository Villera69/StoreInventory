namespace Store;
public abstract class DairyProduct : Product
{
    protected double percentFat;

    public override abstract String Print();

    public override void AddValuesToParameters(){
        bool containsInt = true;
        bool isDouble = false;
        productID = UnixTimeNow();
        do
        {
            Console.Clear();
            Console.Write("Type the name of the product: ");
            name = Console.ReadLine();
            if (name.Length > 0)
            {
                containsInt = name.Any(char.IsDigit);
            }

            if(containsInt){
                Console.WriteLine("\nYou need to write a name with at least 1 letter, and it should not contain any digits. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (containsInt);
        do
        {
            Console.Clear();
            Console.Write("\nType the price you wish to sell it at: ");
            isDouble = double.TryParse(Console.ReadLine(), out price);
            if(price <= 0){
                isDouble = false;
            }
            if(!isDouble){
                Console.WriteLine("\nInput the price using only positive numbers and a maximum of 2 decimal points. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isDouble);
        do
        {
            Console.Clear();
            Console.Write("\nType the percentage of fat in the product: ");
            isDouble = double.TryParse(Console.ReadLine(), out percentFat);
            if(percentFat < 0 || percentFat > 100){
                isDouble = false;
            }
            if(!isDouble){
                Console.WriteLine("\nInput the percentage using only numbers and a maximum of 2 decimal points. It has to be between 0 and 100 percent. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isDouble);
    }
}