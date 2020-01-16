using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Birthday_Exam_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            var aquariumvolume = lenght * width * height;
            var aquariumtotal = aquariumvolume * 0.001;
            var percent2 = percent * 0.01;
            var realrequiredliters = aquariumtotal * (1-percent2);
            Console.WriteLine($"{realrequiredliters:F2}");
        }
    }
}
