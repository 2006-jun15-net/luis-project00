﻿using System;
using System.Collections.Generic;

namespace StoreApplication.DatabaseAccess.Model
{
    public partial class OrderLines
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
