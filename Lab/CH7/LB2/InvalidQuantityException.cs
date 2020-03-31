using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class InvalidQuantityException : ArgumentException
    {
        public InvalidQuantityException() : base("Invalid Quantity")
        {

        }
    }
}
