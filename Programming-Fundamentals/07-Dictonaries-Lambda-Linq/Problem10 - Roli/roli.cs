using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Roli_TheCoder_MyAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, List<string>>> data = new Dictionary<int, Dictionary<string, List<string>>>();

            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> value = new List<string>();
            

            while (input[0] != "Time for Code")
            {

                if (data.ContainsKey(int.Parse(input[0])) == false)
                {
                    Dictionary<string, string> current = new Dictionary<string, string>();
                    current.Add(input[1], );
                    data.Add(int.Parse(input[0]), current);
                }





                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
