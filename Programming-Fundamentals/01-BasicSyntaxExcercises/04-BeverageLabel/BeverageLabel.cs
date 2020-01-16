using System;

class BeverageLabel
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyContent = double.Parse(Console.ReadLine());
        double sugarContent = double.Parse(Console.ReadLine());

        var energyPer100ml = (volume / 100) * energyContent;
        var sugarPer100ml = (volume / 100) * sugarContent;

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{energyPer100ml}kcal, {sugarPer100ml}g sugars");
    }
}
