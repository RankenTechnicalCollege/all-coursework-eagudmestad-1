using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Demo
{
   public class Dog : Animal
    {
        public int SenseOfSmell { get; set; }
        public string Fetch()
        {
            return "...dog runs away, grabs the stick, and returns it.";
        }

        public override string Walk()
        {
            return "... the dog is walking on all fours...";
        }

        public override string ToString()
        {
            return base.ToString() + 
                $" and this dog has a sense of smell {SenseOfSmell}/10";
        }
    }
}
