using System;
using System.Linq;
using System.Collections.Generic;

namespace p04_RoliTheCoder
{
    class Roli  ///////// 80%
    {
        static void Main(string[] args) /// The other 20% are probably new eventID with the same eventName.
        {
            string read = Console.ReadLine();
            Dictionary<int, Dictionary<string, List<string>>> data = new Dictionary<int, Dictionary<string, List<string>>>();
            Dictionary<string, List<string>> eventsData = new Dictionary<string, List<string>>();

            while (read != "Time for Code")
            {
                string[] input = read.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                int eventID = int.Parse(input[0]);
                string eventName = input[1];

                if (!data.ContainsKey(eventID)) /// Dosen't Contain Key
                {
                    if (!eventsData.ContainsKey(eventName) && eventName.Contains('#')) /// Dosen't Contain Event && Event Starts With #
                    {
                        List<string> participants = new List<string>();  /// Adds Only Unique Members
                        for (int i = 2; i < input.Length; i++)
                        {
                            if (!participants.Contains(input[i]) && input[i].Contains('@'))
                            {
                                participants.Add(input[i]);
                            }
                        }
                        eventsData.Add(eventName, participants);
                        data.Add(eventID, eventsData);
                    }
                }
                else
                {
                    if (data.ContainsKey(eventID))   /// If Key Exists
                    {
                        if (eventsData.ContainsKey(eventName)) /// If Event Exists
                        {
                            for (int i = 2; i < input.Length; i++)  /// Adds Only Unique Members
                            {
                                if (!eventsData[eventName].Contains(input[i]) && input[i].Contains('@'))
                                {
                                    eventsData[eventName].Add(input[i]);
                                }
                            }
                        }
                    }
                }
                read = Console.ReadLine();
            }
            foreach (var events in eventsData.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))  /// Printing
            {
                Console.WriteLine($"{events.Key.TrimStart('#')} - {events.Value.Count}");
                foreach (var person in events.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{person}");
                }
            }
        }
    }
}
