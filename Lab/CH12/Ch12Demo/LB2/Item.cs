using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Item
    {
        //Auto Implememented
        public string Name { get; set; }
        public string UPC { get; set; }
        public decimal StorePrice { get; set; }
        public decimal CasePrice { get; set; }
        public int UnitsPerCase { get; set; }
        public string Distributor { get; set; }

    }
}
