using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Celsius_To_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var Celsius = double.Parse(Console.ReadLine());
            var CtoF = Celsius * 1.8 + 32;
            Console.WriteLine(CtoF);
        }
    }
}
