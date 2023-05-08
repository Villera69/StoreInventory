namespace Store;
public abstract class DairyProduct : Product //Klassen för produkttypen Dairy product, subklass av product
{
    protected double percentFat;

    public override abstract String Print(); //Denna följer med från product

    public override void AddValuesToAttributes(){   //Här tilldelas värden till de olika attributerna av produkterna. Denna funktion inheritas till alla subklasser.
        bool containsInt = true;
        bool isDouble = false;
        productID = CurrentUnixTime(); //Unix time är antal sekunder från 1970, ett sätt att få unika produkt ID:n för alla olika produkter.
        do  //namnet tilldelas här
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
        do  //Här skriver användaren in priset
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
        do  //Användaren stoppar in produktens fetthalt här.
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