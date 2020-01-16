using System;

namespace _03_BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            if (minutes >= 30)
            {
                hours++;
                minutes = (minutes + 30) - 60;
                if (hours >= 23)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else if (minutes < 30)
            {
                minutes += 30;
                if (hours >= 23)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}
