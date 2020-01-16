using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Score:");
            var score = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (score <= 100)
            {
                bonus = bonus+5;
            }
            else if (score > 100 & score<= 1000)
            {
                bonus = score * 0.2;
            }
            else if (score > 1000)
            {
                bonus = score * 0.1;
            }
            if (score % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (score % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine("Bonus Score:" + bonus);
            Console.WriteLine("Total Score:" + (score+bonus));
        }
    }
}
