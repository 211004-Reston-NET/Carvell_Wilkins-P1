using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class StoreFrontMenu : IMenu
    {
       
         private IStoreFrontBL _StoreBL;
         
         public StoreFrontMenu(IStoreFrontBL p_StoreBL)
         {
             _StoreBL = p_StoreBL;


         }

        public void Menu()
        {
            
            Console.WriteLine("Please choose a City from the list to find a ");
            Console.WriteLine("store near you");
            Console.WriteLine("======================");
            Console.WriteLine("======================");

            Console.WriteLine("List of Stores");
           

            /*Console.WriteLine("[10] - New York, NY");
            Console.WriteLine("[9] - Los Angeles, CA");
            Console.WriteLine("[8] - Chicago, IL");
            Console.WriteLine("[7] - Houston, TX");
            Console.WriteLine("[6] - Phoenix, AZ");
            Console.WriteLine("[5] - Philadelphia, PA");*/
             Console.WriteLine("[4] - San Antonio, TX" );
             Console.WriteLine("[3] - San Diego, CA");
             Console.WriteLine("[2] - Dallas, TX");
             Console.WriteLine("[0] - Go Back");
             

        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
                case "0":
                    Console.WriteLine("Exiting back to the Main Menu. Press enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;
                case "2":
                    Console.WriteLine("You have chosen Dallas, Tx. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name= "Dallas TX";
                    return MenuType.LineItem;
                case "3":
                    Console.WriteLine("You have chosen San Diego, CA. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name= "San Diego CA";
                    return MenuType.LineItem;
                case "4":
                     Console.WriteLine("You have chosen San Antonio, TX. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "San Antonio TX";
                    return MenuType.LineItem;
                
                /*case "5":
                    Console.WriteLine("You have chosen Philadelphia, PA. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "Philadelphia PA";
                    return MenuType.LineItem;
                case "6":
                    Console.WriteLine("You have chosen Phonex, AZ. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "Phonex AZ";
                    return MenuType.LineItem;
                case "7":
                    Console.WriteLine("You have chosen Houston, TX. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "Houston TX";
                    return MenuType.LineItem;

                case "8":
                    Console.WriteLine("You have chosen Chicago, IL. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "Chicago IL";
                    return MenuType.LineItem;
                
                case "9":
                    Console.WriteLine("You have chosen Los Angeles, CA . Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "Los Angeles CA";
                    return MenuType.LineItem;
                case "10":
                    Console.WriteLine("You have chose New York, NY. Please press enter to continue");
                    SingletonStoreFront.storeFront.Name = "New York NY";
                    return MenuType.LineItem;*/
               
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreFront;
            }
        }
    }
}