﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OLIVIEM.Models
{
   public class Product
    {
        public List<string> Categorylist { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        //public string Image { get; set; }

        public Product() { }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Product(int Id, string name, string size, string color, decimal price, int quantity, string description, string categoryName, string image)
        {
            Id = id;
            Name = name;
            Size = size;
            Color = color;
            Price = price;
            Quantity = quantity;
            Description = description;
            CategoryName = categoryName;
            Image = image;
        }
    }
}
