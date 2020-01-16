using System;

class Nto1
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int currentNumber = number; currentNumber >= 1; currentNumber--)
        {
            Console.WriteLine(currentNumber);
        }
    }
}
