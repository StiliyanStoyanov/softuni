using System;

namespace _13_Triangle_ExamExcercise // Not Finished
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (4 * size) + 1;
            char dot = '.';
            char hashtag = '#';
            char space = ' ';

            string firstRow = new string(hashtag, width);
            Console.WriteLine(firstRow);

            int countOfDots = 1;
            int countofHashtags = (width - 3) / 2;
            int countOfWhiteSpace = 1;

            string toFormat = "{0}{1}{2}{1}{0}";

            int rows = size / 2;
            for (int i = 0; i < rows; i++)
            {
                string dots = new string(dot, countOfDots);
                string hashtags = new string(hashtag, countofHashtags);
                string spaces = new string(space, countOfWhiteSpace);

                Console.WriteLine(toFormat, dots, hashtags, spaces);

                countOfDots++;
                countOfWhiteSpace += 2;
                countofHashtags -= 2;
            }


        }
    }
}
