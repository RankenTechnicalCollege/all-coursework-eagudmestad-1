using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class InvalidItemNumberException : ArgumentException
    {
        public InvalidItemNumberException() : base("Invalid Item Number")
        {

        }
    }
}
