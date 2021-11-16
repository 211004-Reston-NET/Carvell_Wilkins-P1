
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUSModels
{
    public class OrderPlacement
    // The orders contain information about customer orders.
    {
        // private List<LineItem> _lineItems = new List<LineItem>();

        //***this section I commented out so that I may scaffel correctly and at price 
        // private List<Product> _product;
        // public List<Product> Product
        // {
        //     get { return _product; }
        //     set { _product = value; }
        // }
        
       
       [Key]
        public int OrderId {get; set;}
        
        public int StoreFrontId {get;set;}
        
        // public int ProductId {get;set;}
                
        public int CustomerId { get; set; }

        public int ProductId {get; set;}
        

     
        /*Changed Total price to Price. doing this so that orderplacement could show the price*/
        public int Price { get; set; }

        
       // public OrderPlacement orderPlacement {get;set;}
        public virtual StoreFront StoreFront {get;set;}
        // public List<LineItem> LineItems {get;set;}
        // public Product product {get;set;}

        
       public virtual Customer Customer { get; set; }

       public virtual Product Product {get; set;}
       
               /*Changed Total price to Price. doing this so that orderplacement could show the price changed 11/16*/

        // public int Price
        // {
        //     get
        //     {
        //         return _price;
        //     }
        //     set
        //     {
        //         _price = value;
        //     }
        // }
       
    }
}