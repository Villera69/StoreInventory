using System.Security.Authentication;
namespace Store;

public class DairyStore{
    Inventory inventory = new();
    bool keepGoing;
    int removeID;
    public void Run(){
        MainMenu();
    }
    void MainMenu(){
        do
        {
            Console.WriteLine("Welcome to the store inventory. What would you like to do?");
            Console.WriteLine("(1) Add a product to the store");
            Console.WriteLine("(2) Edit a product in the inventory");
            Console.WriteLine("(3) View Inventory");
            Console.WriteLine("(4) Exit the program");
            switch (Console.ReadLine())
            {
                case "1":
                    AddProductMenu();
                    break;
                case "2":
                    EditProductMenu();
                    break;
                case "3":
                    Console.Clear();
                    inventory.PrintInventory();
                    break;
                case "4":
                    keepGoing = false;
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
        do
        {
            Console.WriteLine("What type of product do you wish to add?");
            Console.WriteLine("(1) Cheese");
            Console.WriteLine("(2) Milk");
            Console.WriteLine("(3) Yoghurt or Sourmilk");
            Console.WriteLine("(4) Butter");
            Console.WriteLine("(5) Cream");
            Console.WriteLine("(6) Exit the add product menu");
            switch(Console.ReadLine())
            {
                case "1":
                    Cheese cheese = new();

                    Console.Write("\nType the amount of products of this type you want to add: ");
                    int amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {
                        inventory.Add(cheese);
                    }
                    break;
                case "2":
                    Milk milk = new();

                    Console.Write("\nType the amount of products of this type you want to add: ");
                    amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {
                        inventory.Add(milk);
                    }
                    break;
                case "3":
                    YoghurtAndSourmilk yoghurtAndSourmilk = new();

                    Console.Write("\nType the amount of products of this type you want to add: ");
                    amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {
                        inventory.Add(yoghurtAndSourmilk);
                    }
                    break;
                case "4":
                    Butter butter = new();

                    Console.Write("\nType the amount of products of this type you want to add: ");
                    amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {
                        inventory.Add(butter);
                    }
                    break;
                case "5":
                    Cream cream = new();

                    Console.Write("\nType the amount of products of this type you want to add: ");
                    amount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < amount; i++)
                    {
                        inventory.Add(cream);
                    }
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
    public void EditProductMenu(){
        while (true)
        {
            Console.WriteLine("(1) Remove product using product ID");
            Console.WriteLine("(2) Change the  price of a product");
            Console.WriteLine("(3) Print the current inventory");
            Console.WriteLine("(4) Exit to Main menu");
            switch (Console.ReadLine())
            {
                case "1":
                    do
                    {
                        Console.WriteLine("Write the product ID of the product you wish to remove.");
                        keepGoing = int.TryParse(Console.ReadLine(), out removeID);

                    } while (!keepGoing);

                    break;
                case "2":
                    
                    break;

                case "3":
                    Console.Clear();
                    inventory.PrintInventory();
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