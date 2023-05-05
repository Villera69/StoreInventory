namespace Store;
public abstract class DairyProduct : Product
{
    protected double percentFat;
    public DairyProduct(){}

    public override abstract String Print();

    public override void AddValuesToParameters(){
        bool containsInt = true;
        bool isDouble = false;
        bool isInt = false;
        do
        {
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
            Console.Write("\nType the products ID: ");
            isInt = int.TryParse(Console.ReadLine(), out productID);
            if(productID.ToString().Length != 6){
                isInt = false;
            }
            if(!isInt){
                Console.WriteLine("\nThe product ID is an integer containing only 6 numbers. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isInt);
        do
        {
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
            Console.Write("\nType the percentage of fat in the product: ");
            isDouble = double.TryParse(Console.ReadLine(), out percentFat);
            if(percentFat <= 0){
                isDouble = false;
            }
            if(!isDouble){
                Console.WriteLine("\nInput the percentage using only positive numbers and a maximum of 2 decimal points. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
            }
        } while (!isDouble);
    }
}