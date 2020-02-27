using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Chair
    {
        //Instance fields
        private string _chairColor;
        //Static Field
        private static int _totalChairs;
        
        //Auto Implemented Property
        public int NumWheels { get; set; }
        public int ChairHeight { get; set; }

        //Property
        public string ChairColor
        {
            set
            {
                if (value == "green")
                {
                    //Give the user an error message
                }
                else
                {
                    _chairColor = value;
                }
            }
            get
            {
                return _chairColor;
            }
        }

        //Constructor
        public Chair()
        {
            _totalChairs++;
        }
        //Constructor w/ 2 params
        public Chair(string chairColor, int numWheels)
        {
            _chairColor = chairColor;
            NumWheels = numWheels;
            _totalChairs++;
        }
      
        //Methods to set and get values in our instance fields
        //Aka Setters and Getters
        public static int GetTotalChairs()
        {
            return _totalChairs;
        }
        public void SetChairColor(string color)
        {
            _chairColor = color;
        }
        public void SetNumWheels(int numWheels)
        {
           NumWheels = numWheels;
        }
        public string GetChairColor()
        {
            return _chairColor;
        }
        public int GetNumWheels()
        {
            return NumWheels;
        }


    }
}
