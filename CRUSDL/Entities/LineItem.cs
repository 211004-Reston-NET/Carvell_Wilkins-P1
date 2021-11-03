using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class LineItem
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
