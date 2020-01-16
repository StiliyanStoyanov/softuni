using System;

namespace Finances
{
    class Annuity
    {
        static void Main(string[] args)
        {
            double PV = double.Parse(Console.ReadLine()); /// Present Value
            double period = double.Parse(Console.ReadLine()); /// Number of Periods
            double r = double.Parse(Console.ReadLine());  /// Interest rate

            r = r * 0.01 / 12;           /// Monthly interest rate

            double discount = Math.Pow((double)(1 + r), (double)period * -1);  /// discount factor
            discount = 1 - (discount);                          /// discount factor
            double annuityPayment = ((PV) * r / discount);

            for (int i = 1; i <= period; i++)
            {
                Console.WriteLine();
                double interestPayment = PV * r;
                double principalPayment = annuityPayment - interestPayment;
                double remainingPrincipal = PV - principalPayment;
                PV = PV - annuityPayment;

                Console.WriteLine($"{i} Month Payment = {annuityPayment:F2} || Principal Payment = {principalPayment:F2}" +
                    $" || Interest Payment {interestPayment:F2} || Remaining Principle = {remainingPrincipal:F2} ");
            }
            Console.WriteLine("\n \n \n \n \n \n");
        }
    }
}
