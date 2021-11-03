using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class OrderPlacement
    {
        public int OrderPlacementId { get; set; }
        public string StoreFrontName { get; set; }
        public int? ProductId { get; set; }
        public string Decription { get; set; }

        public virtual Customer OrderPlacementNavigation { get; set; }
    }
}
