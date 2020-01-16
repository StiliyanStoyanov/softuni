using System;

namespace _04_Training
{
    class Training
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometersRun = double.Parse(Console.ReadLine());

            var startDay = kilometersRun;

            for (int i = 0; i < days; i++)
            {
                int percentFormIncrease = int.Parse(Console.ReadLine());
                startDay = startDay + (percentFormIncrease * 100);

            }
            Console.WriteLine(startDay);
        }
    }
}
