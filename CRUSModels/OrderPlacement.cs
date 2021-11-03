
using System;
using System.Collections.Generic;

namespace CRUSModels
{
    public class OrderPlacement
    // The orders contain information about customer orders.
    {
        private List<LineItem> _lineItems = new List<LineItem>();
        public int OrderId {get; set;}
        public int StoreFrontId {get;set;}

        public int ProductId {get;set;}
        
        private int _customerId { get; set; }
        
        private int _totalPrice;

        public Customer Customer {get; set;}
        public StoreFront StoreFront {get;set;}
        public List<LineItem> LineItems {get;set;}

        
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