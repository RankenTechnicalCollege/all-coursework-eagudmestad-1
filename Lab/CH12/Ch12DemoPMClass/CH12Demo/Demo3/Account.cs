using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class Account
    {

        //Static Field
        private static int _totalAccounts;

        public string AccountNumber { get; set; }
        public string AccountPin { get; set; }
        public string UserName { get; set; }

       public Account()
        {
            _totalAccounts++;
        }

        public Account(string accountNum)
        {
            accountNum = accountNum;
        }

        public static int GetTotalAccounts()
        {
            return _totalAccounts;
        }


        ////Instance Fields
        //private string _accountNumber;
        //private string _accountPin;

        ////Auto-Implemented Property
        //public string UserName { get; set;}

        ////Constructor
        //public Account(string accountNum,string pin)
        //{
        //    _accountNumber = accountNum;
        //    _accountPin = pin;
        //}

        ////Default Constructor
        //public Account()
        //{

        //}

        ////getters and setters
        ////methods to assign values to the fields
        ////or get values out of the fields
        //public void SetAccountNumber(string number)
        //{
        //    _accountNumber = number;
        //}
        //public void SetAccountPin(string pin)
        //{
        //    _accountPin = pin;
        //}
        //public string GetAccountNumber()
        //{
        //    return _accountNumber;
        //}
        //public string GetAccountPin()
        //{
        //    return _accountPin;
        //}

        ////Properties
        ////New to C#....does not exist in Java
        //public String AccountNumber
        //{
        //    get
        //    {
        //        return _accountNumber;
        //    }
        //    set
        //    {
        //        if(Convert.ToDouble(value) < 0)
        //        {
        //            //Give an error message
        //            //Business Logic
        //        }
        //        else
        //        { 
        //            _accountNumber = value;
        //        }
        //    }
        //}
    }
}
