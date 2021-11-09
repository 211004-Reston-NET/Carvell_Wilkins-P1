
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUSModels
{
    public class OrderPlacement
    // The orders contain information about customer orders.
    {
        // private List<LineItem> _lineItems = new List<LineItem>();
        private List<Product> _product;
        public List<Product> Product
        {
            get { return _product; }
            set { _product = value; }
        }
        
       
       [Key]
        public int OrderId {get; set;}
        
        public int StoreFrontId {get;set;}
        
        // public int ProductId {get;set;}
                
        public int CustomerId { get; set; }
        

     
        
        private int _totalPrice;

        
       // public OrderPlacement orderPlacement {get;set;}
        public virtual StoreFront StoreFront {get;set;}
        // public List<LineItem> LineItems {get;set;}
        // public Product product {get;set;}

        
       public virtual Customer Customer { get; set; }
       
        public int TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }
        }
       
    }
}