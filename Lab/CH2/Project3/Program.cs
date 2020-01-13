using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======");
            Console.WriteLine("Enter the first name:");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter the second name:");
            string name2 = Console.ReadLine();

            Console.WriteLine("Enter the third name:");
            string name3 = Console.ReadLine();

            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine("| Year       |{0,-11}|{1,-11}|{2,-11}|", name1, name2, name3);

        }
    }
}
