using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StarEnigma
{
    class StarEnigma /// 80% 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, List<string>> book = new SortedDictionary<string, List<string>>();
            book.Add("A", new List<string>());
            book.Add("D", new List<string>());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int key = Regex.Matches(input, "[star]", RegexOptions.IgnoreCase).Count;
 
                char[] charArray = input.ToCharArray();
                for (int x = 0; x < charArray.Length; x++)
                {
                    int code = charArray[x] - key;
                    charArray[x] = (char) code;
                }
                
                string deciphered = new String(charArray);

                MatchCollection matches = Regex.Matches(deciphered, @"(@[A-Za-z]+)[^@\-!:>]*(:[0-9]+)[^@\-!:>]*!([AD])![^@\-!:>]*->([0-9]+)");

                foreach (Match match in matches)
                {
                    string planetName = match.Groups[1].ToString();
                    int planetPopulation = int.Parse(match.Groups[2].ToString());
                    string attackType = match.Groups[3].ToString();
                    int soldierCount = int.Parse(match.Groups[4].ToString());

                    book[attackType].Add(planetName);
                }
            }
            foreach (KeyValuePair<string, List<string>> item in book)
            {
                item.Value.Sort();
                string type = item.Key == "A" ? "Attacked" : "Destroyed";
                Console.WriteLine($"{type} planets: {item.Value.Count}");
                foreach (string planet in item.Value)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
