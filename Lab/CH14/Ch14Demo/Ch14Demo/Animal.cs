using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Demo
{
   public class Animal : Object
    {
        private string _name;
        private double _weight;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Double Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public virtual string Walk()
        {
            return "...the animal is walking...";
        }

        public override string ToString()
        {
            return $"The animals name is {Name} and weight is {Weight}";
        }

        public override bool Equals(object obj)
        {
           Animal animal2 = (Animal)obj;
            
            bool isEqual = false;
            if(this.Name == (animal2.Name)  && this.Weight == animal2.Weight)
            {
                isEqual = true;
            }

            return isEqual;
        }
    }
}
