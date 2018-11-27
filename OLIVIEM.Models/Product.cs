using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
   public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        //public string Image { get; set; }
        
        public Product() { }
        public Product(string name, string size, string color, decimal price, int quantity/*, string image*/)
        {
            Name = name;
            Size = size;
            Color = color;
            Price = price;
            Quantity = quantity;
            //Image = image;
      


        }
    }
}
