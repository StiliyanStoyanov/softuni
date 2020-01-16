using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toSkip = array[0];
            int toTake = array[1];

            string input = Console.ReadLine();
            string pattern = @"\|<([\w]{" + toSkip + @"})([\w]{0," + toTake + @"})";

            MatchCollection myMathecs = Regex.Matches(input, pattern);
            List<string> result = new List<string>();

            foreach (Match m in myMathecs)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
