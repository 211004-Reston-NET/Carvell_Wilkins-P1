using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class Product
    {
        public string Brand { get; set; }
        public string ClothingType { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? ProductId { get; set; }
    }
}
