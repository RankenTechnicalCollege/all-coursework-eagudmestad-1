using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    public enum SodaFlavor
    {
        NONE,
        LIME,
        PEACH,
        MANGO
    }
    public class Soda
    {
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = .15;
        private SodaFlavor _flavor;
        private double _price;

        public SodaFlavor Flavor
        {
            get => _flavor;
        }

        public double Price
        {
            get => _price;
        }

        public Soda()
        {
            _price += BASE_PRICE;
            _flavor = SodaFlavor.NONE;
        }

        public void AddFlavor(SodaFlavor f)
        {
            if(_flavor == SodaFlavor.NONE)
            { 
                _flavor = f;
                _price += FLAVOR_PRICE;
            }
        }

    }
}
