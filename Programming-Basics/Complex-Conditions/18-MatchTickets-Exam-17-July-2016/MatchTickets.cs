using System;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = (Console.ReadLine());
            var numberofpeople = int.Parse(Console.ReadLine());

            var vipticket = 499.99;
            var normalticket = 249.99;
            var totalvipticketprice = vipticket * numberofpeople;
            var totalnormalticketprice = normalticket * numberofpeople;

            double remaininghmoney = 0;
            double moneyafterviptickets = 0;
            double moneyafternormaltickets = 0;
            double transport = 0;

            bool from1to4 = (numberofpeople >= 1 && numberofpeople <= 4);
            bool from5to9 = (numberofpeople >= 5 && numberofpeople <= 9);
            bool from10to24 = (numberofpeople >= 10 && numberofpeople <= 24);
            bool from25to49 = (numberofpeople >= 25 && numberofpeople <= 49);
            bool from50ormore = (numberofpeople >= 50);
            if (from1to4) transport = budget * 0.75;
            else if (from5to9) transport = budget * 0.60;
            else if (from10to24) transport = budget * 0.50;
            else if (from25to49) transport = budget * 0.40;
            else if (from50ormore) transport = budget * 0.25;

            remaininghmoney = budget - transport;
            moneyafterviptickets = remaininghmoney - totalvipticketprice;
            moneyafternormaltickets = remaininghmoney - totalnormalticketprice;

            if (category == "VIP" && remaininghmoney >= totalvipticketprice)
            {
                Console.WriteLine($"Yes! You have {moneyafterviptickets:F2} leva left.");
            }
            else if (category == "VIP" && remaininghmoney < totalvipticketprice)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(moneyafterviptickets));
            }
            if (category == "Normal" && remaininghmoney >= totalnormalticketprice)
            {
                Console.WriteLine($"Yes! You have {moneyafternormaltickets:F2} leva left.");
            }
            else if (category == "Normal" && remaininghmoney < totalnormalticketprice)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(moneyafternormaltickets));
            }
        }
    }
}
