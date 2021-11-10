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
        }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
    

