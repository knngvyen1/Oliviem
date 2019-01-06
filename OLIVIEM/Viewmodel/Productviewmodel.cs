using Microsoft.AspNetCore.Http;
using Models;
using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLIVIEM.Viewmodel
{
    public class Productviewmodel
    {
        public List<Product> products { get; set; }
        public List<Product> Categorylist { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}
