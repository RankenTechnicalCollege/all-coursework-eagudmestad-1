using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Student
    {
        //Data
        //Aka Variables
        //Aka Instance Fields
        private string _name;
        private int _age;

        //Constructor
        //A method with the same as the class
        //and NO RETURN DATA TYPE
        //also public
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //No Arg Constructor
        public Student()
        {

        }

        //Behaviors
        //Aka Methods

        //Mutator
        //Change the _name field
        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        //Accessor
        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
