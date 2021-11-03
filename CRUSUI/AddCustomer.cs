using System;
using CRUSBL;
using CRUSModels;

namespace CRUSUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _customer = new Customer();
        private ICustomerBL _customerBL;

        public AddCustomer(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }

        public void Menu()
        {

            Console.WriteLine(" Name - " + _customer.Name);
            Console.WriteLine(" Email - " + _customer.Email);
            Console.WriteLine(" Address - " + _customer.Address);
            Console.WriteLine("Adding a new Customer Store");
            Console.WriteLine("[4] - Add Customer ");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for Email");
            Console.WriteLine("[1] - Input value for Address");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string YourChoice = Console.ReadLine();
            switch (YourChoice)
            {
                case "4":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                        _customerBL.AddCustomer(_customer);
                    }
                    catch (System.Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomer;
                    }

                    return MenuType.MainMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _customer.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the Email");
                    _customer.Email = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the Address");
                    _customer.Address = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}