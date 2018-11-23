using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum Status
    {
      Verwerken,
      Verpakken,
      Verzonden,
      Bezorgd
    }

    public class Order
    {
        public DateTime Date { get; set; }
        public int Ordernumber { get; set; }
        public List<Product> Products { get; set; }
        public Order(DateTime date, int ordernumber, List<Product> products)
        {
            Date = date;
            Ordernumber = ordernumber;
            Products = products;
        }
    }
}

