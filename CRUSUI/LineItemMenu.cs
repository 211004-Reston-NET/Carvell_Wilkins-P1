using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class LineItemMenu : IMenu
    {
        private ILineItemBL _lineItemBL;
        public LineItemMenu(ILineItemBL p_lineItemBL)
        {
            _lineItemBL = p_lineItemBL;
        }
        
        
        public void Menu()

        {
            
            Console.WriteLine($"Now viewing products from {SingletonStoreFront.storeFront.Name}");
            Console.WriteLine(" Please take a look of all items listed.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine( "================================");
            Console.WriteLine( "================================");
            Console.WriteLine ();
            Console.WriteLine("[5] Nike Pants" );
            Console.WriteLine("[4] Nike Shirt");
            Console.WriteLine("[3] Adidas Pants");
            Console.WriteLine("[2] Adidas Shirt");
            Console.WriteLine("[1] Go back to the previous menu");
            
            Console.WriteLine("[0] Return to Main Menu");

            // List<LineItem> lineItemList = _lineItemBL.GetAllLineItems(SingletonStoreFront.ProductId);

        //     foreach (LineItem item in lineItemList)
        //     {
        //         Console.WriteLine(item);
        //         Console.WriteLine("--------------");
        //     }
        //     Console.WriteLine("[1] Place an Order");
        //     Console.WriteLine("[0] Go back");

        //     Console.WriteLine("===================================");
        //     Console.ReadLine();
         }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            

            {
               
                case "0":
                    Console.WriteLine("Exiting back to the Main Menu. Press enter to continue.");
                    Console.ReadLine();
                    return MenuType.MainMenu;

                case "1":
                    Console.WriteLine("Exiting back to previous menu. Press enter to continue.");
                    Console.ReadLine();
                    return MenuType.StoreFront;
                case "5":
                    Console.WriteLine("You have chosen Nike Pants. Please press enter to continue");
                    //SingletonStoreFront.product.Name= "Nike pants";
                    return MenuType.OrderPlacement;
                case "4":
                    Console.WriteLine("You have chosen Nike Shirt. Please press enter to continue");
                    SingletonStoreFront.product.Name= "Nike shirt";
                    return MenuType.CategoryMenu;
                case "3":
                     Console.WriteLine("You have chosen Adidas Shirt. Please press enter to continue");
                    SingletonStoreFront.product.Name = "Adidas Shirt";
                    return MenuType.CategoryMenu;
                case "2":
                 Console.WriteLine("You have chosen Adidas Shirt. Please press enter to continue");
                    SingletonStoreFront.product.Name = "Adidas Shirt";
                    return MenuType.CategoryMenu;

                   
          



                
                default:
                    Console.WriteLine("Please input a valid response! Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}

