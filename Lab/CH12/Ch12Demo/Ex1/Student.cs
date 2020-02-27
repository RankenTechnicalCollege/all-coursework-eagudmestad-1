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
        //Instance Fields
        private string _studentName;
        private int _id;

        //Constructor
        //Is a method that has the same name as the class
        //Can be used to set the instance field values

        //no arg constructor
        public Student()
        {

        }
        public Student(string name,int id)
        {
            _studentName = name;
            _id = id;
        }


        //Methods
        //The concept of data hiding 
        //is where the instance fields are marked
        //as private
        //and public methods are used to 
        //ACCESS and MODIFY the data
        //SetId is called a MUTATOR
        public void SetId(int id)
        {
            if(id < 0)
            {
                //error message
                _id = 0;
            }
            else
            {
                //set the _id instance field
                _id = id;
            }
        }

        public int GetId()
        {
            return _id;
        }

        public void SetStudentName(string name)
        {
            _studentName = name;
        }

        public string GetStudentName()
        {
            return _studentName;
        }

        public override string ToString()
        {
            return $"{_studentName}'s id is {_id}\n";
        }


    }
}
