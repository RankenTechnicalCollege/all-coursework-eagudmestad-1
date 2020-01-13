using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for their name
            Console.WriteLine("Please enter your name");

            //Reads they keyboard input and
            //stores in a variable
            string name = Console.ReadLine();
            
            //Prompt the user for their age
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();

            Console.WriteLine("How much money do you have?");
            double money = Convert.ToDouble(Console.ReadLine());

            //Output Hello with the users name
            Console.WriteLine("Hello {0} you are {1} years old.", name,age);
            Console.WriteLine("You have {0:C}", money);


        }
    }
}
