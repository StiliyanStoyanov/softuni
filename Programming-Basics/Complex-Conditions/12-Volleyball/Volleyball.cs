using System;

namespace _12_Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yeartype = (Console.ReadLine());   //// Leap(високосна) или normal(невисокосна)
            double p = int.Parse(Console.ReadLine());  ///// брой празници в годината (които не са събота и неделя)
            double h = int.Parse(Console.ReadLine());  //// брой уикенди в които влади пътува
            double TotalWeekendsinAYear = 48;
            double WeekendinSofia = (TotalWeekendsinAYear - h) * 3.0 / 4;

            double GamesinHomeTown = h;
            double GamesinSofia = p * (2.0 / 3);

            double AllGames = WeekendinSofia + GamesinHomeTown + GamesinSofia;
            double ifYear = 0;

            if (yeartype == "leap")
            {
                ifYear = (15 * AllGames) / 100;
            }
            double final = Math.Truncate(ifYear + AllGames);
            Console.WriteLine(final);
        }
    }
}
