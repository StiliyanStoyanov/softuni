using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            int count = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string ip;
            string user;
            int duration = 0;

            for (int i = 0; i < count; i++)
            {
                ip = input[0];
                user = input[1];
                duration = int.Parse(input[2]);
                if (logs.ContainsKey(user) == false)
                {
                    Dictionary<string, int> currentLog = new Dictionary<string, int>();
                    currentLog.Add(ip, duration);
                    logs.Add(user, currentLog);
                }
                else
                {
                    if (logs[user].ContainsKey(ip) == false)
                    {
                        logs[user].Add(ip, duration);
                    }
                    else if (logs[user].ContainsKey(ip) == true)
                    {
                        logs[user][ip]+=duration;
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var pair in logs.OrderBy(p => p.Key))
            {
                Console.Write($"{pair.Key}: {pair.Value.Values.Sum()} ");
                Console.Write("[");
                Console.Write(string.Join (", ", pair.Value.Keys.OrderBy(x => x)));
                Console.WriteLine("]");
            }
        }
    }
}
