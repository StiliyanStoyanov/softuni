using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = Console.ReadLine().Split(" ").ToArray();
            List<string> gameData = input.Split(" ").ToList();

            while (data[0] != "Play!")
            {
                string command = data[0];
                string game = data[1];
                if (command == "Install")
                {
                    if (!gameData.Contains(game))
                    {
                        gameData.Add(game);
                    }
                }
                if (command == "Uninstall")
                {
                    if (gameData.Contains(game))
                    {
                        gameData.Remove(game);
                    }
                }
                if (command == "Update")
                {
                    if (gameData.Contains(game))
                    {
                        gameData.Remove(game);
                        gameData.Add(game);
                    }
                }
                if (command == "Expansion")
                {

                    string expansionUpdated = "";
                    string[] expansion = game.Split("-").ToArray();
                    if (gameData.Contains(expansion[0]))
                    {
                        if (game.Contains("-"))
                        {
                            for (int i = 1; i < expansion.Length; i++)
                            {
                                expansionUpdated = expansionUpdated + expansion[i];
                            }
                            string gameNameUpdated = expansion[0] + ":" + expansionUpdated;
                            int position = 0;
                            for (int i = 0; i < gameData.Count; i++)
                            {
                                if (gameData[i] == expansion[0])
                                {
                                    position = i;
                                    gameData.Insert(position + 1, gameNameUpdated);
                                }
                            }
                        }
                    }
                }
                data = Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine(string.Join(" ", gameData));
        }
    }
}
