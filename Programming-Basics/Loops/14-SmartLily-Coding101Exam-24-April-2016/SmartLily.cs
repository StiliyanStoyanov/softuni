using System;

namespace _14_SmartLily_ExamExcercise2
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var toyprice = int.Parse(Console.ReadLine());

            var oddbirthdays = 0;
            var evenbirthdays = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    oddbirthdays++;
                }
                else
                {
                    evenbirthdays++;
                }
            }
            var oddMoney = toyprice * oddbirthdays;
            var evenBirthdaysMoney = 0;
            var evenMoney = 0;
            for (int i = 1; i <= evenbirthdays; i++)
            {
                evenBirthdaysMoney += 10;
                evenMoney += evenBirthdaysMoney;

            }
            var brotherMoney = 1 * evenbirthdays;
            var totalMoney = (oddMoney + evenMoney) - brotherMoney;
            if (totalMoney > price)
            {
                Console.WriteLine($"Yes! {totalMoney - price:F2}");
            }
            else if (price > totalMoney)
            {
                var difference = Math.Abs(price - totalMoney);
                Console.WriteLine($"No ! {difference:F2}");
            }
        }
    }
}
