using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
  enum Direction
    {
        North,
        South,
        East,
        West
    }
    class Program
    {
        static void Main(string[] args)
        {
            int age = 1;

            string name = "Bob";
            Direction userSelection = Direction.East;
            switch(userSelection)
            {
                case Direction.East:
                    Console.WriteLine("Move character East");
                    break;
                case Direction.North:
                    Console.WriteLine("Hi Tim");
                    break;
                default:
                    Console.WriteLine("I don't know how old you are");
                    break;
            }

        }
    }
}
