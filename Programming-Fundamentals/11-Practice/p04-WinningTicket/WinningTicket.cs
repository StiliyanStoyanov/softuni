using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_WinningTicket
{
    class WinningTicket //////////////// 70%
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([@#$^]{6,10})+([^@#$^\s]*)([@#$^]{6,10})+";
            string [] split = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Length == 20)
                {
                    Match match = Regex.Match(split[i], pattern);
                    if (match.Success)
                    {
                        if (match.Groups[1].Length == match.Groups[3].Length)
                        {
                            Match symbol = Regex.Match(split[i], @"[@#$^]");
                            if (match.Groups[1].Length + match.Groups[3].Length == 20)
                            {
                                Console.WriteLine($"ticket \"{split[i]}\" - {match.Groups[1].Length}{symbol} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{split[i]}\" - {match.Groups[3].Length}{symbol}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{split[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
