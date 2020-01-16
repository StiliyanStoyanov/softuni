using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Tailors_Workshop_Exam_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var AmountOfTables = double.Parse(Console.ReadLine());
            var LengthOfTheTables = double.Parse(Console.ReadLine());
            var WidthOfTheTables = double.Parse(Console.ReadLine());
            var TotalAreaofCovers = AmountOfTables * (LengthOfTheTables + 2 * 0.30) * (WidthOfTheTables + 2 * 0.30);
            var TotalAreaofCarriage = AmountOfTables * (LengthOfTheTables / 2) * (LengthOfTheTables/2);
            var PriceInUSD = (TotalAreaofCovers * 7) + (TotalAreaofCarriage * 9);
            var PriceInBGN = PriceInUSD * 1.85;
            Console.WriteLine("{0} USD", Math.Round(PriceInUSD, 2)); /// Закръгля но не записва нулите
            Console.WriteLine("{0} BGN", Math.Round(PriceInBGN, 2)); /// /// Закръгля но не записва нулите
            Console.WriteLine($"{PriceInUSD:F2} USD"); /// Вярно в Judge
            Console.WriteLine($"{PriceInBGN:F2} BGN"); /// Вярно в Judge
            Console.WriteLine($"{PriceInUSD:N2} USD"); /// Закръгля правилно но с запетая
            Console.WriteLine($"{PriceInBGN:N2} BGN"); /// Закръгля правилно но с запетая
        }
    }
}
