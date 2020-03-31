using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class InvalidWeightException : ArgumentException
    {
        public InvalidWeightException() : base("INVALID WEIGHT")
        {

        }
    }
}
