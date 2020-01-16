using System;
using System.Collections.Generic;
using System.Linq;

namespace p04
{
    class Forcebook
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            List<string> input = data.Split("|->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (data != "Lumpawaroo")
            {
                if (data.Contains("|"))
                {
                    var forceUser = input[1].Trim();
                    var forceSide = input[0].Trim();
                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }

                    bool userExists = false;
                    foreach (var pair in forceBook)
                    {
                        if (pair.Value.Contains(forceUser))
                        {
                            userExists = true;
                        }
                    }

                    if (userExists == false)
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                else if (data.Contains("->"))
                {
                    string forceUser = input[0].Trim();
                    string forceSide = input[1].Trim();
                    if (!forceBook.Keys.Contains(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }
                    foreach (var user in forceBook)
                    {
                        if (user.Value.Contains(forceUser))
                        {
                            user.Value.Remove(forceUser);
                        }
                    }
                    forceBook[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                data = Console.ReadLine();
                input = data.Split("|->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var record in forceBook.Where(f => f.Value.Count > 0).OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
            {
                Console.WriteLine($"Side: {record.Key}, Members: {record.Value.Count}");

                foreach (string user in record.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
