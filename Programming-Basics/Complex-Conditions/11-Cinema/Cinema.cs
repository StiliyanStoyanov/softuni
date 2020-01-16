using System;

namespace _11_Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = (Console.ReadLine());
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            var result = 0.0;
            if (type == "Premiere")
            {
                var price = 12;
                result = (rows * columns) * price;
            }
            else if (type == "Normal")
            {
                var price = 7.5;
                result = (rows * columns) * price;
            }
            else if (type == "Discount")
            {
                var price = 5;
                result = (rows * columns) * price;
            }
            Console.WriteLine($"{result:F2}");

        }
    }
}
