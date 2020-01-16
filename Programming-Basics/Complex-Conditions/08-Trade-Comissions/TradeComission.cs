using System;

namespace _08_Trade_Comissions
{
    class TradeComission
    {
        static void Main(string[] args)
        {
            var town = (Console.ReadLine());
            var sales = double.Parse(Console.ReadLine());
            bool SalesTo500 = sales <= 500 && sales >= 0;
            bool Sales500To1000 = sales > 500 && sales <= 1000;
            bool Sales1000To10000 = sales > 1000 && sales <= 10000;
            bool SalesOver10000 = sales > 10000;
            var commision = 0.0;
            if (town == "Sofia")
            {
                if (SalesTo500)
                    commision = 0.05;
                else if (Sales500To1000)
                    commision = 0.07;
                else if (Sales1000To10000)
                    commision = 0.08;
                else if (SalesOver10000)
                    commision = 0.12;
            }
            else if (town == "Varna")
            {
                if (SalesTo500)
                    commision = 0.045;
                else if (Sales500To1000)
                    commision = 0.075;
                else if (Sales1000To10000)
                    commision = 0.10;
                else if (SalesOver10000)
                    commision = 0.13;
            }
            else if (town == "Plovdiv")
            {
                if (SalesTo500)
                    commision = 0.055;
                else if (Sales500To1000)
                    commision = 0.08;
                else if (Sales1000To10000)
                    commision = 0.12;
                else if (SalesOver10000)
                    commision = 0.145;
            }
            if (commision > 0)
            {
                Console.WriteLine($"{sales * commision:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
