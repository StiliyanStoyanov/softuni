using System;

namespace _07_Left_or_Right_Sum
{
    class LeftOrRightSum
    {
        static void Main(string[] args)
        {
            int readNumbers = int.Parse(Console.ReadLine());

            int leftSum = 0;
            for (int i = 1; i <= readNumbers; i++)  //// LEFT
            {
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }
            int rightSum = 0;
            for (int i = 1; i <= readNumbers; i++) //// RIGHT
            {
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }

            bool AreSumsEqual = leftSum == rightSum;
            var differenceInSum = Math.Abs(leftSum - rightSum);
            if (AreSumsEqual)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff {differenceInSum}");
            }
        }
    }
}
