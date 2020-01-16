using System;
class PowersOfTwo
{
    static void Main(string[] args)
    {
        int readNumber = int.Parse(Console.ReadLine());

        int num = 1;
        for (int i = 0; i <= readNumber; i++)
        {
            Console.WriteLine(num);
            num *= 2;
            int power = (int)Math.Pow(2, i);
            Console.WriteLine(power);
        }
    }
}
