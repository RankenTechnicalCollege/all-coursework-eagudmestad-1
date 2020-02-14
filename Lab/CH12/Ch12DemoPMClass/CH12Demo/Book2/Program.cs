using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassifiedAd myAd = new ClassifiedAd();
            ClassifiedAd yourAd = new ClassifiedAd();

            myAd.Category = "Used Guitar";
            myAd.NumWords = 10;

            yourAd.Category = "Used Car";
            yourAd.NumWords = 1000;

            Console.WriteLine($"The {myAd.Category} has {myAd.NumWords} words and costs {myAd.Price:C}");
            Console.WriteLine($"The {yourAd.Category} has {yourAd.NumWords} words and costs {yourAd.Price:C}");
        }
    }
}
