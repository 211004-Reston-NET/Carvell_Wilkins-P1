using System;
using System.Text.RegularExpressions;

namespace CRUSModels

{
    public class Customer
    {
        public int CustomerId ;
        private string _name;
        private string _email;
        private string _address;
        //private List<Orders> _orders = new List<Orders>();
        public int ID { get; set; }

        

        public string Name
        {
            get{
                return _name;
            }
            set{
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+(\s[a-zA-Z]+)?$"))
                {
                    throw new Exception("Name can only hold letters.");
                }
                _name = value;

            }
        }
         public string Email
        {
            get{
                return _email;
            }
            set{
                
                _email = value;

            }
        }
         public string Address
        {
            get{
                return _address;
            }
            set{
                
                _address = value;

            }
        }
    }
}