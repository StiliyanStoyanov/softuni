using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var usdtolv = usd * 1.79549;
            Console.WriteLine("{0} BGN", Math.Round(usdtolv, 2));
        }
    }
}
