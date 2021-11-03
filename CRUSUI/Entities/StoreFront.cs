using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSUI.Entities
{
    public partial class StoreFront
    {
        public StoreFront()
        {
            OrderPlacements = new HashSet<OrderPlacement>();
            Products = new HashSet<Product>();
        }

        public int StoreFrontId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ListOfProducts { get; set; }
        public string ListOfOrders { get; set; }

        public virtual ICollection<OrderPlacement> OrderPlacements { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
