﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
   public class CartItem
    {

        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
