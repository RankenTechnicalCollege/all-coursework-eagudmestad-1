using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output
            Console.WriteLine("What is your name?");

            //Input from the user
            string name = Console.ReadLine();

            Console.WriteLine("What is your salary?");
            float salary = Convert.ToSingle(Console.ReadLine());

            salary = salary * 2;

            //Output the name to the Console
            Console.WriteLine("Hello {0} your doubled salary is {1:C}",name,salary);
        }
    }
}
