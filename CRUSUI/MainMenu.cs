

using System;

namespace CRUSUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {

        /*
   Since MainMenu has inherited IMenu, it will have all the methods we have created
   in IMenu.
   This is an example of Inheritance, one of the Object Oriented Pillars
*/
        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("Where would you like to go?");
            //Console.WriteLine("[4] - search for Prodcuts "); 
            Console.WriteLine("[3] - Login information");
            Console.WriteLine("[2] - Create a new User");
            Console.WriteLine("[1] - Go to Clothes R' US");
            Console.WriteLine("[0] - Exit");
        }

      
        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //case "4":
                //return MenuType.CategoryMenu;
                case "3":
                    return MenuType.CustomerSearch;
                case "2":
                    return MenuType.AddCustomer;                    
                case "1":
                    return MenuType.StoreFront;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}