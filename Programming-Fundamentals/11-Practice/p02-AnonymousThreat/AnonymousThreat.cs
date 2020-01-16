using System;
using System.Linq;
using System.Collections.Generic;

namespace p02_AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "3:1")
            {
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (command == "merge")
                {
                    if (true)
                    {
                        
                    }
                }









                commands = Console.ReadLine().Split(' ').ToArray();
            }



        }
    }
}
