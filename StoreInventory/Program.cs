using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
namespace Store;

static class Program{
    public static void Main(){
    }

    static void MainMenu1(){
        while (true)
        {
            Console.WriteLine("Welcome to the dairy store. Are you a customer or an administrator? Choose by entering one of the numbers in the menu below");
            Console.WriteLine(" (1) Administrator");
            Console.WriteLine(" (2) Customer");
            String choice = Console.ReadLine();
            switch (choice)
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
    static void AdminMenu(){
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
                    RemoveProductMenu();
                    break;

                case "3":
                    ChangePriceMenu();
                    break;
                default:
                    Console.WriteLine("That is not an available number. Please enter a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
    static void AddProductMenu(){
        Console.WriteLine("What type of product do you wish to add?");
        Console.WriteLine("(1) Cheese");
        Console.WriteLine("(2) Milk");
        Console.WriteLine("(3) Yoghurt or Sourmilk");
        Console.WriteLine("(4) Butter");
        Console.WriteLine("(5) Cream");
        String choice = Console.ReadLine();
        switch(choice)
        {
            case "1":
                Console.Clear();
                Console.Write("Type the name of the product: ");
                String name = Console.ReadLine();
                Console.Write("\nType the price you wish to sell it at: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("\nType the productID: ");
                int productID = int.Parse(Console.ReadLine());
                Console.Write("\nType the age of the cheese: ");
                int age = int.Parse(Console.ReadLine());

                Cheese cheese = new Cheese(price, productID, name, age);

                Console.Write("\nType the amount of products of this type you want to add: ");
                int amount = int.Parse(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Inventory.inventory.Add(cheese);
                }

                break;
            case "2":
                Console.Clear();
                Console.Write("Type the name of the product: ");
                String name = Console.ReadLine();
                Console.Write("\nType the price you wish to sell it at: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("\nType the productID: ");
                int productID = int.Parse(Console.ReadLine());
                Console.Write("\nType the type of milk you wish to add: ");
                MilkType milkType = ;
                Console.Write("\nType the amount of products of this type you want to add: ");
                int amount = int.Parse(Console.ReadLine());

                break;
        }
        
    }
    static void CustomerMenu(){
        while (true)
        {
            Console.WriteLine("Welcome, Customer");
            Console.WriteLine("(1) Browse the shop");
            Console.WriteLine("(2) View Cart");
            Console.WriteLine("(3) Go to checkout");
            String choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Shop();
                    break;
                case "2":
                    ViewCart();
                    break;
                case "3":
                    Checkout();
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

