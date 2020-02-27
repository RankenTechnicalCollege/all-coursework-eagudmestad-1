using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
    public enum SundaeTopping
    {
        NONE,
        SPRINKLES,
        NUTS,
        CHOCOLATE_SYRUP
    }
    public class Sundae
    {
        //Constants
        public const double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = .5;
        //Instance Fields
        private SundaeTopping[] _toppings = new SundaeTopping[2];
        private int _toppingCount;
        private double _price;
        //Properties
        public int ToppingCount
        {
            get => _toppingCount;
        }

        public double Price
        {
            get => _price;
        }
        //Default Constructor
        public Sundae()
        {
            _toppingCount = 0;
            _price += BASE_PRICE;
        }
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddTopping(SundaeTopping t)
        {
            if(_toppingCount < 2)
            { 
                _toppings[_toppingCount] = t;
                _toppingCount++;
                _price += TOPPING_PRICE;
            }
        }

    }
}
