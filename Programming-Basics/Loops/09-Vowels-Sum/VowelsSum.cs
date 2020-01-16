using System;

namespace _09_Vowels_Sum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());

            int sum = 0;
            for (int currentIndex = 0; currentIndex < word.Length; currentIndex++)
            {
                char symbol = word[currentIndex];
                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
