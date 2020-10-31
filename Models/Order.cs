using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace candrea_anamaria_lab2.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int BookID { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }

    }
}
