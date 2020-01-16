using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace p03_PheonixGird
{
    class PheonixGird
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"^([^\s_]{3}\.)+([^\s_]{3})*$");

            while (input != "ReadMe")
            {
                if (pattern.IsMatch(input) || input.Length == 3)
                {
                    bool isPalindrome = true;

                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        if (input[i] != input[input.Length - 1 - i])
                        {
                            Console.WriteLine("NO");
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }
    }
}
