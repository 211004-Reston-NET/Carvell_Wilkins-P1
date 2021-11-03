using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSUI.Entities
{
    public partial class OrderPlacement
    {
        public OrderPlacement()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int OrderId { get; set; }
        public int? StoreFrontId { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
