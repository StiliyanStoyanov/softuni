using System;
using System.Linq;

namespace p02_Icarus
{
    class Icarus
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentPosition = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int damage = 1;

            while (input != "Supernova")
            {
                string[] command = input.Split(' ');
                string movePosition = command[0];
                int timesToMove = int.Parse(command[1]);
                if (movePosition == "right")
                {
                    for (int i = 1; i <= timesToMove; i++)
                    {
                        if (currentPosition + 1 > plane.Length - 1)
                        {
                            currentPosition = 0;
                            damage++;
                            plane[currentPosition] -= damage;
                        }
                        else
                        {
                            plane[currentPosition + 1] -= damage;
                            currentPosition++;
                        }
                    }
                }
                else if (movePosition == "left")
                {
                    for (int i = 1; i <= timesToMove; i++)
                    {
                        if (currentPosition - 1 < 0)
                        {
                            currentPosition = plane.Length-1;
                            damage++;
                            plane[currentPosition] -= damage;
                        }
                        else
                        {
                            plane[currentPosition - 1] -= damage;
                            currentPosition--;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', plane));
        }
    }
}
