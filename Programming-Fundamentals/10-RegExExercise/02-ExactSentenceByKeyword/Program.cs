using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_ExactSentenceByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string[] sentances = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\b{word}\b";


            foreach (var sentance in sentances)
            {
                if (Regex.IsMatch(sentance,pattern))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
