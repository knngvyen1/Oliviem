using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLIVIEM.Viewmodel
{
    public enum Status
    {
        Verwerken,
        Verpakken,
        Verzonden,
        Bezorgd
    }
    public class OrderViewModel
    {
        public class Order
        {
            public DateTime Date { get; set; }
            public int Ordernumber { get; set; }
            public List<Product> Products { get; set; }
        }
    }
}
