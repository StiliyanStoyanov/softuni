using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NumberFrom100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            var Number = int.Parse(Console.ReadLine());
            if (Number < 100)
            {
                Console.WriteLine($"{"Less than 100"}");
            }
            else if (Number >= 100 & Number <= 200)
            {
                Console.WriteLine($"{"Between 100 and 200"}");
            }
            else if (Number > 200)
            {
                Console.WriteLine($"{"Greater than 200"}");
            }
        }
    }
}
