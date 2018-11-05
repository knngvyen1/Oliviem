using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Product
    {
        public string  Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }

        public Product( string name, string size, string color, double price, string category, int stock)
        {
            Name = name;
            Size = size;
            Color = color;
            Price = price;
            Category = category;
            Stock = stock;
        }
    }

}
