using System;

namespace _01_DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysNames =
            {
                "Понеделник",
                "Вторинк",
                "Tретък",
                "Четвъртък",
                "Петък",
                "Събота",
                "Неделя"
            };

            daysNames[2] = "Сряда";

            int day = int.Parse(Console.ReadLine());
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysNames[day-1]);
            }
        }
    }
}
