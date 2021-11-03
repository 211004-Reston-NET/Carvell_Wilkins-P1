using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class Order
    {
        public int? PersonId { get; set; }
        public string Address { get; set; }
        public int? OrderId { get; set; }
        public string Name { get; set; }

        public virtual Customer Person { get; set; }
    }
}
