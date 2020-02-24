using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5
{
    public class Job
    {
        public const double TRIP_FEE=35;
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;
       
        
     

        public Job(string description,float hoursToComplete,float hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
            _totalFee = (_hoursToComplete * _hourlyFee) + (float)TRIP_FEE;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public float HoursToComplete
        {
            set
            { 
                _hoursToComplete = value;
                _totalFee = (_hoursToComplete * _hourlyFee) + (float)TRIP_FEE;
            }
            get
            {
                return _hoursToComplete;
            }
        }

        public float HourlyFee
        {
            get => _hourlyFee;
            set
            {
                _hourlyFee = value;
                _totalFee = (_hoursToComplete * _hourlyFee) + (float)TRIP_FEE;
            }
        }

        public float TotalFee
        {
            get
            {
                return _totalFee;
            }
        }



    }
}
