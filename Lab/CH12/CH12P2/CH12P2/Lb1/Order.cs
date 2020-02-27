using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    public class Order
    {
        //Instance Fields
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        public String Name
        {
            get => _name;
        }

        public Sundae Sundae
        {
            get => _sundae;
        }

        public Soda Soda
        {
            get => _soda;
        }

        public double Price
        {
            get
            {
                double total = 0;
                if (_soda != null)
                {
                    total += _soda.Price;
                }
                if(_sundae != null)
                {
                    total += _sundae.Price;
                }
                return total;
            }
        }

        //Order Constructor
        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;

            if (hasSundae)
            {
                _sundae = new Sundae();
            }

            if (hasSoda)
            {
                _soda = new Soda();
            }

        }
    }
}
