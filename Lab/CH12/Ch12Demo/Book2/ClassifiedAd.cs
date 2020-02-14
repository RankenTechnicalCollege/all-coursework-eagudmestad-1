using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2
{
    public class ClassifiedAd
    {
        //Instance Fields
        private int _numWords;
        private string _category;
        private decimal _price;

        //Property
        public int NumWords
        {
            set
            {
                _numWords = value;
                _price = _numWords * .09m;
            }
            get
            {
                return _numWords;
            }
        }

        //Property
        public string Category
        {
            set
            {
                _category = value;
            }
            get
            {
                return _category;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
        }
    }
}
