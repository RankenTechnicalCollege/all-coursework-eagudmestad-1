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
            myAd.Category = "Used Guitar";
            myAd.NumWords = 10;

            ClassifiedAd yourAd = new ClassifiedAd();
            yourAd.Category = "Used Car";
            yourAd.NumWords = 1000;

            Console.WriteLine($"My Ad category is for a {myAd.Category} and is {myAd.NumWords} words will cost {myAd.Price:C}");
            Console.WriteLine($"Your Ad category is for a {yourAd.Category} and is {yourAd.NumWords} words will cost you {yourAd.Price:C}");
        }
    }
}
