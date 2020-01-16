using System;
using System.Text.RegularExpressions;

namespace p03_Regexmon
{
    class Regexmon /// 40%
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string bojoPattern = (@"[A-Za-z]+-[A-Za-z]+");
            string didiPattern = (@"[^A-Za-z-]+");
            MatchCollection bojo = Regex.Matches(input, bojoPattern);
            MatchCollection didi = Regex.Matches(input, didiPattern);

            if (didi.Count >= 1 && bojo.Count >= 1)
            {
                for (int i = 0; i < didi.Count; i++)
                {
                    if (didi.Count % 2 == 1)
                    {
                        if (i >= bojo.Count)
                        {
                            return;
                        }
                        Console.WriteLine(didi[i]);
                        Console.WriteLine(bojo[i]);

                    }
                    else
                    {
                        Console.WriteLine(didi[i]);
                        if (i >= bojo.Count)
                        {
                            return;
                        }
                        Console.WriteLine(bojo[i]);
                    }
                }
            }
        }
    }
}
