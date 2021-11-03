using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSUI.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            OrderPlacements = new HashSet<OrderPlacement>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<OrderPlacement> OrderPlacements { get; set; }
    }
}
