using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var Speed = double.Parse(Console.ReadLine());
            if (Speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (Speed > 10 & Speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (Speed > 50 & Speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (Speed > 150 & Speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (Speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
