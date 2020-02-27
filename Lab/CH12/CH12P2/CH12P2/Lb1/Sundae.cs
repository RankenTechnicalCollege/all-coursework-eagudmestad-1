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
        //Instance Fields
        public const Double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = .5;
        private SundaeTopping[] _toppings=new SundaeTopping[2];
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

        //Constructor
        public Sundae()
        {
            _price += BASE_PRICE;
            _toppingCount = 0;
            _toppings[0] = SundaeTopping.NONE;
        }

        //Accessor Method
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }

        //Mutator method
        public void AddTopping(SundaeTopping t)
        {
            if(_toppingCount < 2)
            { 
                _toppings[_toppingCount] = t;
                _price += TOPPING_PRICE;
                _toppingCount++;
            }
        }


    }
}
