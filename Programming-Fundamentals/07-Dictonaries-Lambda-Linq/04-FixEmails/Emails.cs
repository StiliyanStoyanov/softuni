using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();
            string commands = Console.ReadLine();
            string email = "";
            string name = "";

            while (commands != "stop")
            {
                name = commands;
                email = Console.ReadLine();
                if (emailList.ContainsKey(name) == false)
                {
                    emailList.Add(name, email);
                }
                commands = Console.ReadLine();
            }

            foreach (var pair in emailList.Where(x => x.Value.EndsWith(".us") == false && x.Value.EndsWith(".uk") == false))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
