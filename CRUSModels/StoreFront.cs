using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUSModels
{
    public class StoreFront
    // The store front contains information pertaining the various store locations
    {
        [Key]
        public int StoreFrontId { get; set; }
        public string Name {get;set;}
        
        public string Description { get; set; }
        public string Address {get;set;}

        // public String ListOfProducts {get;set;}
        // public String ListOfOrders {get;set;}

        private List<OrderPlacement> _orderPlacement;
        public List<Product> Products {get;set;}

         //public ICollection<Product> Products { get; set; }
        //private List<Products> _products;
        ///private List<Orders> _orders;
        //private int _storefrontid;
       
        //{
        //get { return _storefrontid; }
        // set { _storefrontid = value; }
        //}

        //properties
       
        
   
        
         public List<OrderPlacement> OrderPlacement
         {
             get
             {
                 return _orderPlacement;
             }
             set
             {
                 _orderPlacement = value;
             }
         }

        public override string ToString()
        {
            return $"Name: {Name} \nAddress: {Address} ";
        }

        /*public override string ToString()
            {
                return $"Name: {Name} \nAddress: {Address} \nLocation: {Location} ";
            } */
    }
}