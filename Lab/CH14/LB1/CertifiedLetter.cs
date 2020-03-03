using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
   public class CertifiedLetter : Letter
    {
        protected string _trackingNumber;

        public CertifiedLetter(string recipient,DateTime sentDate,string trackingNumber) : base(recipient,sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + _trackingNumber;
        }

        public string TrackingNumber
        {
            get => _trackingNumber;
        }

        public override double Price => .65;

    }
}
