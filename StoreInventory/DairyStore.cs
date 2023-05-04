using System.Security.Authentication;
namespace Store;

public class DairyStore{

    Inventory inventory = new();
    public void Run(){
        MainMenu();
    }
    void MainMenu(){
        while (true)
        {
            Console.WriteLine("Welcome to the dairy store. Are you a customer or an administrator? Choose by entering one of the numbers in the menu below");
            Console.WriteLine(" (1) Administrator");
            Console.WriteLine(" (2) Customer");
            switch (Console.ReadLine())
            {
                case "1":
                    AdminMenu();
                    break;
                case "2":
                    CustomerMenu();
                    break;
                default:
                    Console.WriteLine("That is not an available number.Please type a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
    void AdminMenu(){
        while (true)
        {
            Console.WriteLine("Welcome, Administrator");
            Console.WriteLine(" (1) Add a product to the store");
            Console.WriteLine(" (2) Remove a product from the store");
            Console.WriteLine(" (3) Change the price of any currently stocked product");
            String choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProductMenu();
                    break;
                case "2":
                    //RemoveProductMenu();
                    break;

                case "3":
                    //ChangePriceMenu();
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
    void AddProductMenu(){
        Boolean keepGoing = true;
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
    static void CustomerMenu(){
        while (true)
        {
            Console.WriteLine("Welcome, Customer");
            Console.WriteLine("(1) Browse the shop");
            Console.WriteLine("(2) View Cart");
            Console.WriteLine("(3) Go to checkout");
            switch (Console.ReadLine())
            {
                case "1":
                    //Shop();
                    break;
                case "2":
                    //ViewCart();
                    break;
                case "3":
                    //Checkout();
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