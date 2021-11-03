
using System;
using System.Collections.Generic;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class ShowCustomers : IMenu
    {
        private ICustomerBL _customerBL;
        public ShowCustomers(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public void Menu()
        {
            Console.WriteLine("Current List of Customers");
            Console.WriteLine("==========================");
            List<Customer> listOfCustomers = _customerBL.GetAllCustomer();
            foreach (Customer customer in listOfCustomers)
            {
                Console.WriteLine(customer);
                Console.WriteLine("=====================");
            }
            Console.WriteLine("[0] - Go back");
        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                     Console.WriteLine("Please press enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }

       
    }
}