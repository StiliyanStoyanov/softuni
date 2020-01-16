using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Charity_Campaing_Exam_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var CampaingDuration = int.Parse(Console.ReadLine());
            var NumberOfCooks = int.Parse(Console.ReadLine());
            var NumberOfCakes = int.Parse(Console.ReadLine());
            var NumberOfWaffles = int.Parse(Console.ReadLine());
            var NumberOfPancakes = int.Parse(Console.ReadLine());
            var CakesIncome = NumberOfCakes * 45;
            var WafflesIncome = NumberOfWaffles * 5.80;
            var PancakesIncome = NumberOfPancakes * 3.20;
            var TotalSumForTheDay = (CakesIncome + WafflesIncome + PancakesIncome) * NumberOfCooks;
            var TotalSumForTheCampaing = TotalSumForTheDay * CampaingDuration;
            var TotalSumAfterExpenses = TotalSumForTheCampaing - (TotalSumForTheCampaing / 8);
            Console.WriteLine($"{TotalSumAfterExpenses:F2}");
        }
    }
}
