using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual OrderPlacement OrderPlacement { get; set; }
    }
}
