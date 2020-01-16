using System;

namespace _02_RectangleNxNstars
{
    class RectangleNxNstars
    {
        static void Main(string[] args)
        {
            int RowsAndColumnsToPrint = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= RowsAndColumnsToPrint; rows++)
            {
                for (int col = 1; col <= RowsAndColumnsToPrint; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
