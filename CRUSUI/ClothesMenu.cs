using System;

namespace CRUSUI
{
    public class ClothesMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Clothing Catagory!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[3] - List of Clothing Stores");
            Console.WriteLine("[2] - Add a Clothing Store");
            Console.WriteLine("[1] - Buy a Product");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "3":
                    return MenuType.ShowClothes;
                case "2":
                    return MenuType.AddCustomer;
                case "1":
                    return MenuType.ClothesMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ClothesMenu;
            }
        }
    }
}