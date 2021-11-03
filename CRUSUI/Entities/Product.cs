using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSUI.Entities
{
    public partial class Product
    {
        public Product()
        {
            LineItems = new HashSet<LineItem>();
            OrderPlacements = new HashSet<OrderPlacement>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? StoreFrontId { get; set; }
        public int? LineItemId { get; set; }

        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<OrderPlacement> OrderPlacements { get; set; }
    }
}
