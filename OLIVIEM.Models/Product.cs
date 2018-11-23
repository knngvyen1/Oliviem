using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
   public class Product
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, string size, string color, decimal price, int quantity)
        {
            Name = name;
            Size = size;
            Color = color;
            Price = price;
            Quantity = quantity;


        }
    }
}
