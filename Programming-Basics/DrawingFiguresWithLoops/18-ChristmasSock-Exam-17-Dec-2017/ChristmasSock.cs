using System;

namespace _25_ChristmasSockMyExam //     40/100 I think Merry-Xmas is not on 3 rows,
                                  //              but is floating depending on size.
{
    class ChristmasSock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var height = 3 * n + 3;

            string firstAndThirdRow = new string('-', n * 2);
            string secondRow = new string('*', n * 2);
            Console.WriteLine("|{0}|", firstAndThirdRow);
            Console.WriteLine("|{0}|", secondRow);
            Console.WriteLine("|{0}|", firstAndThirdRow);

            int dash = (n - 1);
            int wave = 2;
            for (int uppersock = 1; uppersock <= n - 1; uppersock++)
            {
                string tireta = new string('-', dash);
                string vulni = new string('~', wave);
                Console.WriteLine("|{0}{1}{0}|", tireta, vulni);
                dash -= 1;
                wave += 2;
            }
            int dash2 = 2;
            int wave2 = wave - 4;
            for (int middlesock = 1; middlesock <= n - 2; middlesock++)
            {
                string dashes = new string('-', dash2);
                string waves = new string('~', wave2);
                Console.WriteLine("|{0}{1}{0}|", dashes, waves);
                dash2 += 1;
                wave2 -= 2;
            }

            int dot = (n * 2) + 1;
            int dashBottomSock = 0;
            for (int bottomupper = 1; bottomupper <= n / 2; bottomupper++)
            {
                string tochki = new string('.', dot);
                string tireta = new string('-', dashBottomSock);
                Console.WriteLine("{0}\\{1}\\", tireta, tochki);
                dashBottomSock++;
            }

            string Merry = new string('-', dashBottomSock);
            string dotAroundXmas = new string('.', (dot / 2) - 2);
            string Xmas = new string('-', dashBottomSock + 2);
            string dotsBetweenTheLineOfMerryXmas = new string('.', dot);
            string wavesBetweenTheLineofMerryXmas = new string('-', dashBottomSock + 1);
            Console.WriteLine("{0}\\{1}MERRY{1}\\", Merry, dotAroundXmas);
            Console.WriteLine("{0}\\{1}\\", wavesBetweenTheLineofMerryXmas, dotsBetweenTheLineOfMerryXmas);
            Console.WriteLine("{0}\\{1}X-MAS{1}\\", Xmas, dotAroundXmas);

            int tiretaPosledenRed = dashBottomSock + 3;
            for (int bottomSock = 0; bottomSock < n / 2; bottomSock++)
            {
                string tochki = new string('.', dot);
                string tireta = new string('-', tiretaPosledenRed);
                Console.WriteLine("{0}\\{1}\\", tireta, tochki);
                tiretaPosledenRed++;
            }
            Console.WriteLine(new string('-', tiretaPosledenRed) + '\\' + new string('_', dot) + ')');
        }
    }
}
