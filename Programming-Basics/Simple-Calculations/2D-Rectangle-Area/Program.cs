using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var width = Math.Abs(x2 - x1);
            var height = Math.Abs(y2 - y1);

            Console.WriteLine($"Rectangle area = {width*height}");
            Console.WriteLine("Rectangle perimeter = {0}", (width+height)*2);

        }
    }
}
