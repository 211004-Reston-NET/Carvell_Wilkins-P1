
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUSModels
{
    public class OrderPlacement
    // The orders contain information about customer orders.
    {
        private List<LineItem> _lineItems = new List<LineItem>();
        private List<Product> _product;
        public List<Product> Product
        {
            get { return _product; }
            set { _product = value; }
        }
        
       
       [Key]
        public int OrderId {get; set;}
        
        public int StoreFrontId {get;set;}
        
        public int ProductId {get;set;}
                
        private int _customerId { get; set; }
        public Customer Customer {get; set;}

     
        
        private int _totalPrice;

        
       // public OrderPlacement orderPlacement {get;set;}
        public StoreFront StoreFront {get;set;}
        public List<LineItem> LineItems {get;set;}
        public Product product {get;set;}

        
        public int CustomerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId =value;
            }

        }
       
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