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
            this.TotalPrice = p_rest.TotalPrice;
            this.StoreFrontId = p_rest.StoreFrontId;
            
        }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public int StoreFrontId {get; set;}
        
    }
}