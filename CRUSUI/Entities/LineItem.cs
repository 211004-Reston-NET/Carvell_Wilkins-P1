﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CRUSUI.Entities
{
    public partial class LineItem
    {
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int LineItemId { get; set; }
        public int? OrderId { get; set; }

        public virtual OrderPlacement Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
