using System;
using System.Text.RegularExpressions;

namespace _01_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patter = @"(^|(?<=\s))([a-z0-9]+)([_\.-]?[a-z0-9])*@([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([-.][a-z-0-9]+)*";

            MatchCollection matches = Regex.Matches(input, patter);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
