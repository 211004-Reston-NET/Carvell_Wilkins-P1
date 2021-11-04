
using System;
using System.Collections.Generic;
using System.Globalization;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class SearchCustomers : IMenu
    {
        private ICustomerBL _customerBL;
        public SearchCustomers(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("Customer Search");
            Console.WriteLine("===========================");
            Console.WriteLine("Name -" + SingletonCustomer.customer.Name);
            Console.WriteLine("Email Address" + SingletonCustomer.customer.Email);
            // Console.WriteLine("Address" + SingletonCustomer.customer.Address);
            Console.WriteLine("[4] - Change Name ");
            Console.WriteLine("[3] - Change Email Address");
            //Console.WriteLine("[2] - Change Address");
            Console.WriteLine("[1] - Login");
            Console.WriteLine("[0] - Go Back");

        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "4":
                    Console.WriteLine("Please Enter the Correct Name    ");
                    SingletonCustomer.customer.Name = Console.ReadLine().Trim().ToLower(); 
                    return MenuType.CustomerSearch;

                case "3":
                    Console.WriteLine("Please Enter the Correct Email Address  ");
                    SingletonCustomer.customer.Email = Console.ReadLine().Trim().ToLower(); 
                    return MenuType.CustomerSearch;

                // case "2":
                //     Console.WriteLine("Please Enter the Correct Address");
                //     SingletonCustomer.customer.Name = Console.ReadLine().Trim().ToLower(); 
                //     return MenuType.CustomerSearch;

                case "1":
                    Customer tempCust = _customerBL.GetSingleCustomer(SingletonCustomer.customer.Name, SingletonCustomer.customer.Email );
                    if (tempCust != null)
                    {
                        SingletonCustomer.customer = tempCust;
                        Console.WriteLine($" Hello { SingletonCustomer.customer.Name } Welcome!"); 
                        Console.WriteLine (" Please press enter to continue");
                        
                        Console.ReadLine();
                        return MenuType.MainMenu;
                    }
                    Console.WriteLine($"We couldn't find {SingletonCustomer.customer.Name}, in our database.");
                    Console.WriteLine(" Please Verify that your info is correct");
                    Console.WriteLine("Please press enter to continue");                 
                    Console.ReadLine();
                    return MenuType.CustomerSearch;

                case "0":
                    return MenuType.MainMenu;

                default:
                    Console.WriteLine("Please input a valid response!" +
                                    "\n   Pleas press enter to continue");
                    Console.ReadLine();
                    return MenuType.CustomerSearch;
            }
        }

      
    }
}