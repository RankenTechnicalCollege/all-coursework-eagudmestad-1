using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            string name2 = "Jan";
            string name3 = "Joseph";
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine("| Year       |{0,-12}|{1,-12}|{2,-12}|", name,name2,name3);
        }
    }
}
