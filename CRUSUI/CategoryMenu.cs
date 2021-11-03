using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;


namespace CRUSUI
{
    public class CategoryMenu : IMenu
    {
        private IProductBL _productBL;
        public CategoryMenu(IProductBL p_productBL)
        {
            _productBL = p_productBL;
        }
        private static string _search = "none";
        public void Menu()
        {
            Console.WriteLine($"Now viewing products from {SingletonStoreFront.product.Name}");
            Console.WriteLine($"View Products by Category.");
            Console.WriteLine(  $"   Current Category: {_search}");

            Console.WriteLine("=======================================");
            List<Product> listOfProducts = _productBL.getProduct(_search);

            foreach (Product product in listOfProducts)
            {
                Console.WriteLine(product);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("[1] - Search for a new Category" );
            Console.WriteLine("[2] - Categories you may be interested in");
            Console.WriteLine("[0] - Go Back");

        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "1":
                    Console.WriteLine("   Please input the category name");
                    _search = Console.ReadLine().Trim().ToLower();
                    return MenuType.CategoryMenu;
                case "2":
                    Console.WriteLine("Popular Catagories are as followed");
                    Console.WriteLine("============================");
                    Console.WriteLine("Pants");
                    Console.WriteLine("Shirts");
                    Console.WriteLine("Shoes");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.CategoryMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Incorrect response. Please press enter to continue");
                                   
                    Console.ReadLine();
                    return MenuType.CategoryMenu;
            }
        }

       
    }}