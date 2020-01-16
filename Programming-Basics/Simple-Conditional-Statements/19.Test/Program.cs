using System;

class PoolPipes
{
    static void Main()
    {
        Console.Write("Обем на Басейн = ");
        var volume = int.Parse(Console.ReadLine());
        Console.Write("Тръба 1 = ");
        var pipe1 = int.Parse(Console.ReadLine());
        Console.Write("Тръба 2 = ");
        var pipe2 = int.Parse(Console.ReadLine());
        Console.Write("Часове на на отсъствие на работник = ");
        double hours = double.Parse(Console.ReadLine());
        var water = pipe1 * hours + pipe2 * hours;

        if (water <= volume)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(water / volume * 100),
                Math.Truncate(pipe1 * hours / water * 100),
                Math.Truncate(pipe2 * hours / water * 100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
        }
    }
}