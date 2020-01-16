using System;

namespace _07_CakeIngridients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                string ingridients = Console.ReadLine();
                if (ingridients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingridients}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i-1} ingredients.");
                    return;
                }
            }
        }
    }
}
