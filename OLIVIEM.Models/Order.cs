using OLIVIEM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    public class Order
    {

        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public int Ordernumber { get; set; }
        public List<Product> Orderlist { get; set; }

        public Order(DateTime date, int ordernumber, List<Product> products)
        {
            Date = date;
            Ordernumber = ordernumber;
            Orderlist = products;
        }

    }
}

