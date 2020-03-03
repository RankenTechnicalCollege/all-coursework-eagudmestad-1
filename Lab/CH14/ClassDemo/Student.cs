using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Student : Person, ICloneable
    {

        public object Clone()
        {
            //Deep Copy
            Student s = new Student();
            s.Age = this.Age;
            s.Name = this.Name;
            return s;
        }

    }
}
