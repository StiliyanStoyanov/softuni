using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_HandsofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            int sum = 0;
            string[] hand = Console.ReadLine().Split(new char[] { ' ', ':', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = "";
            List<string> cards = new List<string>();
            while (hand[0] != "JOKER")
            {
                name = hand[0];
                cards = hand.Skip(1).ToList();
                cards = cards.Distinct().ToList();
                if (players.ContainsKey(name) == false)
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine().Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            int multiplier = 0;
            int mainValue = 0;
            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                    }
                    string current = card.Remove(card.Length - 1, 1);
                    switch (current)
                    {
                        case "J":
                            mainValue = 11;
                            break;
                        case "Q":
                            mainValue = 12;
                            break;
                        case "K":
                            mainValue = 13;
                            break;
                        case "A":
                            mainValue = 14;
                            break;
                        default: mainValue = int.Parse(current);
                            break;
                    }
                    sum += multiplier * mainValue;
                }
                Console.WriteLine($"{player.Key}: {sum}");
                sum = 0;
            }

        }
    }
}
