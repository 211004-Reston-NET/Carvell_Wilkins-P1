using CRUSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRUSWebUI.Models
{
    public class OrderPlacementVM
    {
        public OrderPlacementVM() 
        {

        }
        public OrderPlacementVM(OrderPlacement p_rest)
        {
            this.OrderId = p_rest.OrderId;
            this.CustomerId = p_rest.CustomerId;
            this.Price = p_rest.Price;
            this.StoreFrontId = p_rest.StoreFrontId;
            this.ProductId = p_rest.ProductId;
            
        }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal Price { get; set; }
        public int StoreFrontId {get; set;}
        public int ProductId {get; set;}
        
    }
}