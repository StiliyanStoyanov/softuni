using System;

namespace _14_Java_ExcerciseExam5November2017
{
    class Java
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = 3 * n + 6;
            int height = 3 * n + 1;

            string emptyspace = new string(' ', n);
            string smoke = new string('~', n);
            for (int smokes = 0; smokes < n; smokes++)
            {
                Console.WriteLine("{0}{1}", emptyspace, smoke);
            }

            string topAndBottomCup = new string('=', length - 1);
            Console.WriteLine(topAndBottomCup);

            for (int cuphandle = 0; cuphandle < n - 2; cuphandle++)
            {
                string label = "JAVA";
                string aroundLabel = new string('~', n);
                string emptyspaces = new string(' ', n - 1);
                Console.WriteLine("|{0}{1}{0}|{2}|", aroundLabel, label, emptyspaces);
            }
            Console.WriteLine(topAndBottomCup);

            var spacesbot = 0;
            int kliomba = n * 2 + 4;
            for (int i = 0; i < n; i++) //down part \@@@@@/
            {
                Console.WriteLine(new string(' ', spacesbot) + "\\" + new string('@', kliomba) + "/");
                spacesbot++;
                kliomba -= 2;
            }
            var cupbottomlength = n * 2 + 6;
            string cupbottom = new string('=', cupbottomlength);
            Console.WriteLine(cupbottom);

            Console.WriteLine("================".Length);
            Console.WriteLine(cupbottom.Length);
        }
    }
}
