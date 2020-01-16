using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine($"{width * height:F2}");
    }
}
