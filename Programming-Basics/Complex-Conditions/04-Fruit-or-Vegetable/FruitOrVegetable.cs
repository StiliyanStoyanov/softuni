using System;


class InvalidNumber
{
    static void Main(string[] args)
    {
        var product = Console.ReadLine().ToLower();
        if (product == "banana" || product == "apple" || product == "kiwi"
           || product == "kiwi" || product == "cherry" || product == "kiwi"
           || product == "lemon" || product == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
