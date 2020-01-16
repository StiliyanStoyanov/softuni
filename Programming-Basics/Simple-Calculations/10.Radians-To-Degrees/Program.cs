using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_To_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radian = double.Parse(Console.ReadLine());
            var radiantodegree = (radian * (180 / Math.PI));
            Console.WriteLine($"{radian} radians = {radiantodegree:F0} degrees");
        }
    }
}
