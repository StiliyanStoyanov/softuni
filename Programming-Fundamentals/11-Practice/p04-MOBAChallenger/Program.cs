using System;
using System.Linq;
using System.Collections.Generic;

namespace p04_MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var playerData = new Dictionary<string, Dictionary<string, int>>();


            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] data = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player = data[0].Trim();
                    string position = data[1].Trim();
                    int skill = int.Parse(data[2]);

                    if (!playerData.ContainsKey(player))
                    {
                        playerData.Add(player, new Dictionary<string, int>());
                        playerData[player].Add(position, skill);
                    }
                    else
                    {
                        if (playerData[player].ContainsKey(position))
                        {
                            if (skill > playerData[player][position])
                            {
                                playerData[player][position] = skill;
                            }
                        }
                        else if (!playerData[player].ContainsKey(position))
                        {
                            playerData[player].Add(position, skill);
                        }
                    }
                }
                else if (input.Contains("vs"))
                {
                    string[] data = input.Split("vs", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player1 = data[0].Trim();
                    string player2 = data[1].Trim();
                    if (playerData.ContainsKey(player1) && playerData.ContainsKey(player2))
                    {
                        bool samePositions = false;
                        foreach (var position in playerData[player1])
                        {
                            if (playerData[player2].ContainsKey(position.Key))
                            {
                                samePositions = true;
                            }
                        }
                        if (samePositions)
                        {
                            int sumPlayer1 = 0;
                            int sumPlayer2 = 0;
                            foreach (var p1 in playerData[player1])
                            {
                                sumPlayer1 += p1.Value;
                            }
                            foreach (var p2 in playerData[player2])
                            {
                                sumPlayer2 += p2.Value;
                            }
                            if (sumPlayer1 == sumPlayer2)
                            {
                                continue;
                            }
                            else
                            {
                                if (sumPlayer1 > sumPlayer2)
                                {
                                    playerData.Remove(player2);
                                }
                                else
                                {
                                    playerData.Remove(player1);
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }


            foreach (var player in playerData.OrderByDescending(x => playerData[x.Key].Values.Sum()).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{player.Key.Trim()}: {playerData[player.Key].Values.Sum()} skill");
                foreach (var item in player.Value.OrderByDescending(x => x.Value).ThenBy(i => i.Key).ThenBy(z => playerData[player.Key]))
                {
                    Console.WriteLine($"- {item.Key.Trim()} <::> {item.Value}");
                }
            }
        }
    }
}
