using System.Security.Authentication;
namespace Store;

public class DairyStore{
    Inventory inventory = new();
    bool keepGoing;
    long changeID;
    double newPrice;
    public void Run(){      
        MainMenu();
    }
    void MainMenu(){
        do
        {
            keepGoing = true;
            Console.Clear();
            Console.WriteLine("\nWelcome to the store inventory. What would you like to do?");
            Console.WriteLine("(1) Add a product to the store");
            Console.WriteLine("(2) Edit a product in the inventory");
            Console.WriteLine("(3) View Inventory");
            Console.WriteLine("(4) Exit the program");
            switch (Console.ReadLine())
            {
                case "1":
                    AddProductMenu();
                    keepGoing = true;
                    break;
                case "2":
                    if (inventory.Empty())
                    {
                        Console.Clear();
                        Console.WriteLine("\nThis option is locked since you have not added any products yet. Press enter to return to the menu.");
                        Console.ReadLine();
                    }else
                    {
                        EditProductMenu();
                    }
                    break;
                case "3":
                    Console.Clear();
                    inventory.PrintInventory();
                    Console.WriteLine("\nPress enter to return to the menu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }while(keepGoing);
    }
    void AddProductMenu(){
        Console.Clear();
        do
        {   keepGoing = true;
            Console.WriteLine("\nWhat type of product do you wish to add?");
            Console.WriteLine("(1) Cheese");
            Console.WriteLine("(2) Milk");
            Console.WriteLine("(3) Yoghurt or Sourmilk");
            Console.WriteLine("(4) Butter");
            Console.WriteLine("(5) Cream");
            Console.WriteLine("(6) Return to the main menu");
            switch(Console.ReadLine())
            {
                case "1":
                    Cheese cheese = new();
                    AddProduct(cheese);
                    break;
                case "2":
                    Milk milk = new();
                    AddProduct(milk);
                    break;
                case "3":
                    YoghurtAndSourmilk yoghurtAndSourmilk = new();
                    AddProduct(yoghurtAndSourmilk);
                    break;
                case "4":
                    Butter butter = new();
                    AddProduct(butter);
                    break;
                case "5":
                    Cream cream = new();
                    AddProduct(cream);
                    break;
                case"6":
                    Console.Clear();
                    keepGoing = false;
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }while (keepGoing);
    }
    public void AddProduct(Product product){
        Console.Write("\nType the amount of products of this type you want to add: ");
        int amount = int.Parse(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            inventory.Add(product);
        }
        Console.WriteLine("\nThe product was successfully added. Press enter to return to the menu.");
        Console.ReadLine();
        Console.Clear();
    }
    public void EditProductMenu(){
        while (true)
        {
            Console.Clear();
            Console.WriteLine("(1) Remove product using product ID");
            Console.WriteLine("(2) Change the price of a product");
            Console.WriteLine("(3) Print the current inventory");
            Console.WriteLine("(4) Exit to Main menu");
            switch (Console.ReadLine())
            {
                case "1":
                    if(inventory.Empty()){
                        Console.WriteLine("The inventory is empty, therefore you cannot use this feature. Press enter to return to the menu.");
                    }
                    do
                    {
                        Console.Clear();
                        Console.Write("Type the product ID of the product you wish to remove: ");
                        if(long.TryParse(Console.ReadLine(), out changeID)){
                            keepGoing = !inventory.Contains(changeID);
                        }
                        else
                        {
                            keepGoing = true;
                        }
                        if (keepGoing)
                        {
                            Console.WriteLine("\nThe product needs to be in the inventory. Press enter to try again or press spacebar to return to the menu.");
                            if(Console.ReadKey().Key == ConsoleKey.Spacebar){
                                break;
                            }
                            Console.Clear();
                        }
                    } while (keepGoing);
                    if(!keepGoing){
                        inventory.Remove(changeID);
                        Console.WriteLine($"\nThe product with the ID {changeID} has been removed from the inventory");
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    if(inventory.Empty()){
                        Console.WriteLine("The inventory is empty, therefore you cannot use this feature. Press enter to return to the menu.");
                        break;
                    }
                    do
                    {
                        Console.Clear();
                        Console.Write("Type the product ID of the product which price you wish to change: ");
                        if(long.TryParse(Console.ReadLine(), out changeID)){
                                keepGoing = !inventory.Contains(changeID);
                            }
                            else
                            {
                                keepGoing = true;
                            }
                        if (keepGoing){
                                Console.WriteLine("\nThe product needs to be in the inventory. Press enter to try again or press spacebar to return to the menu.");
                            if(Console.ReadKey().Key == ConsoleKey.Spacebar){
                                EditProductMenu();
                            }
                            Console.Clear();
                        }
                    } while (keepGoing);
                    do
                    {
                        Console.Clear();
                        Console.Write("\nType the new price you wish to sell it at: ");
                        keepGoing = !double.TryParse(Console.ReadLine(), out newPrice);
                        if(newPrice <= 0){
                            keepGoing = true;
                        }
                        if(keepGoing){
                            Console.WriteLine("\nInput the price using only positive numbers and a maximum of 2 decimal points. Press enter to try again.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (keepGoing);
                    inventory.ChangePrice(changeID, newPrice);
                    break;

                case "3":
                    Console.Clear();
                    inventory.PrintInventory();
                    Console.WriteLine("\nPress enter to continue to the menu.");
                    Console.ReadLine();
                    break;
                case"4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}