using System;

namespace _10_Animal_Type
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var animal = (Console.ReadLine());
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
