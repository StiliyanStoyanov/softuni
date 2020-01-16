using System;

namespace _20_HourglassMarch19_2017
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var size = 2 * n + 1;
            string firstLastRow = new string('*', size);               // First Row Of The Hourglass
            Console.WriteLine(firstLastRow);

            Console.WriteLine(".*{0}*.", new string(' ', size - 4));   // Before The Top

            var dots = 2;                                              // Top of Hourglass
            var kliomba = (2 * n + 1) - 6;
            for (int i = 0; i < (2 * n) / 2 - 2; i++)
            {
                string kliombas = new string('@', kliomba);
                string dot = new string('.', dots);
                Console.WriteLine("{0}*{1}*{0}", dot, kliombas);

                kliomba -= 2;
                dots++;
            }

            Console.WriteLine("{0}*{0}", new string('.', (2 * n) / 2)); // MiddleLine


            dots = (2 * n) / 2;                                        // Bottom of the Hourglass
            kliomba = 0;

            for (int i = 0; i < (2 * n) / 2 - 2; i++)
            {
                dots--;
                string kliombas = new string(' ', kliomba);
                string dot = new string('.', dots);
                Console.WriteLine("{0}*{1}@{1}*{0}", dot, kliombas);
                kliomba++;
            }


            Console.WriteLine(".*{0}*.", new string('@', 2 * n + 1 - 4));   // After The Bottom

            Console.WriteLine(firstLastRow);  // Last Row of The Hourglass



        }
    }

}
