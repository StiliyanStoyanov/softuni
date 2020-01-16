using System;

class Numbers1ToNBy3
{
    static void Main(string[] args)
    {
        int numberRead = int.Parse(Console.ReadLine());

        for (int currentNumber = 1; currentNumber <= numberRead; currentNumber += 3)
        {
            Console.WriteLine(currentNumber);
        }
    }
}
