using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_MemoryView
{
    class MemoryView1 /// 70% 
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] test = { (char)80, (char)101, (char)115, (char)104, (char)111, };

            while (input != "Visual Studio crash")
            {
                string[] split = input.Split(' ').ToArray();
                List<string> data = new List<string>();
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] == "32763")
                    {
                        for (int x = i; x < split.Length - i; x++)
                        {
                            data.Add(split[x]);
                        }
                    }
                }
                int run = int.Parse(data[2]);
                List<char> output = new List<char>();
                for (int z = 4; z < run + 4; z++)
                {
                    int convert = int.Parse(data[z]);
                    output.Add((char)convert);
                }

                for (int i = 0; i < output.Count; i++)
                {
                    Console.Write($"{output[i]}");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
