using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string read = Console.ReadLine();
            int[] input = read.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] bestSequence = new int[length];
            int index = 1;
            int bestLength = 1;
            int bestPosition = 0;
            int bestIndex = 0;

            while (read != "Clone them!")
            {
                input = read.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentLength = 1;
                int startPosition = -1;
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (input[i] == 1 && input[i+1] == 1)
                    {
                        currentLength++;
                        startPosition = i;
                    }
                }
                if (startPosition > 0)
                {
                    startPosition = (startPosition - currentLength) + 2;
                }

                bool didntChange = true;
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestPosition = startPosition;
                    bestIndex = index;
                    bestSequence = input;
                    didntChange = false;
                }
                if (currentLength == bestLength && didntChange)
                {
                    if (bestPosition > startPosition)
                    {
                        bestLength = currentLength;
                        bestPosition = startPosition;
                        bestIndex = index;
                        bestSequence = input;
                    }
                    else if(bestPosition == startPosition)
                    {
                        if (input.Sum() > bestSequence.Sum())
                        {
                            bestLength = currentLength;
                            bestPosition = startPosition;
                            bestIndex = index;
                            bestSequence = input;
                        }
                    }
                }
                read = Console.ReadLine();
                index++;
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(' ', bestSequence));

        }
    }
}
