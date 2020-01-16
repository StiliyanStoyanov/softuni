using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_MemoryView2ndTry
{
    class MemoryView2 /// 100%
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> additonalData = new List<int>();

            while (input != "Visual Studio crash")
            {
                List<int> data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                data.RemoveAll(x => x == 0);
                data.RemoveAll(x => x > 200);
                additonalData.AddRange(data);
                input = Console.ReadLine();
            }
            for (int i = 0; i < additonalData.Count; i++)
            {
                if (additonalData[i] >= 15)
                {
                    Console.Write((char)additonalData[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
