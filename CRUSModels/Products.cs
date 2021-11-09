using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUSModels
{
    public class Product
    {
       
       public int ProductId {get; set;}
       public string Name {get; set;}
        public decimal Price {get;set;}

        public int Quantity { get; set; }

        public int StoreFrontId {get;set;}
        //public int LineItemId {get;set;}

        public StoreFront StoreFront {get; set;}

        //public List<LineItem> LineItems {get;set;}
        public List<OrderPlacement> OrderPlacements {get;set;}
        
       

        
        
}}