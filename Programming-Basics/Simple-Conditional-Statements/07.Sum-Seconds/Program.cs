using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var secs = sec1 + sec2 + sec3;
            var mins = secs / 60;
            var sec = secs % 60;
            if (sec < 10)
            {
                Console.WriteLine(mins + ":0" + sec);
            }
            else
            {
                Console.WriteLine(mins + ":" + sec);
            }
        }
    }
}
