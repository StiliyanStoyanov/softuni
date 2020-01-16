using System;

class MilesToKm
{
    static void Main(string[] args)
    {
        double mile = double.Parse(Console.ReadLine());
        double milesToKm = mile * 1.60934;
        Console.WriteLine($"{milesToKm:F2}");
    }
}
