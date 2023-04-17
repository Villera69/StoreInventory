﻿using System.Collections.Generic;
namespace Store;

static class Program{

    public static void Main(){


    }

    static void MainMenu1(){
        while (true)
        {
            Console.WriteLine("Welcome to the store. Are you a customer or an administrator? Choose by entering one of the numbers in the menu below");
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
                Console.WriteLine("That is not an available number.Please type a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
    static void CustomerMenu(){
        while (true)
        {
            Console.WriteLine("Welcome, Customer");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ();
                    break;
                case "2":
                    ();
                    break;
                default:
                    Console.WriteLine("That is not an available number.Please type a number corresponding to one of the possible choices in the menu. Press enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        }
    }

}

