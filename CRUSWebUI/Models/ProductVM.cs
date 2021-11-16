using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUSModels;

namespace CRUSWebUI.Models
{
    public class ProductVM
    {
        public ProductVM()
        {

        }

        public ProductVM(Product p_rest)
        {
            
            this.Name = p_rest.Name;
            this.Price = p_rest.Price;
            this.Quantity = p_rest.Quantity;
            this.ProductId = p_rest.ProductId;
            this.StoreFrontId = p_rest.StoreFrontId;
        }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int StoreFrontId { get; set; }
    }
}
    

