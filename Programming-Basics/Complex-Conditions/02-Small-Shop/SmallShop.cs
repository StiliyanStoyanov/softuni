using System;

class SmallShop
{
    static void Main(string[] args)
    {
        var product = Console.ReadLine().ToLower();
        var city = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());
        if (city == "sofia")
        {
            var coffeeprice = 0.50;
            var waterprice = 0.80;
            var beerprice = 1.20;
            var sweetsprice = 1.45;
            var peanutsprice = 1.60;
            if (product == "coffee") Console.WriteLine(quantity * coffeeprice);
            else if (product == "water") Console.WriteLine(quantity * waterprice);
            else if (product == "beer") Console.WriteLine(quantity * beerprice);
            else if (product == "sweets") Console.WriteLine(quantity * sweetsprice);
            else if (product == "peanuts") Console.WriteLine(quantity * peanutsprice);
        }
        if (city == "plovdiv")
        {
            var coffeeprice = 0.40;
            var waterprice = 0.70;
            var beerprice = 1.15;
            var sweetsprice = 1.30;
            var peanutsprice = 1.50;
            if (product == "coffee") Console.WriteLine(quantity * coffeeprice);
            else if (product == "water") Console.WriteLine(quantity * waterprice);
            else if (product == "beer") Console.WriteLine(quantity * beerprice);
            else if (product == "sweets") Console.WriteLine(quantity * sweetsprice);
            else if (product == "peanuts") Console.WriteLine(quantity * peanutsprice);
        }
        if (city == "varna")
        {
            var coffeeprice = 0.45;
            var waterprice = 0.70;
            var beerprice = 1.10;
            var sweetsprice = 1.35;
            var peanutsprice = 1.55;
            if (product == "coffee") Console.WriteLine(quantity * coffeeprice);
            else if (product == "water") Console.WriteLine(quantity * waterprice);
            else if (product == "beer") Console.WriteLine(quantity * beerprice);
            else if (product == "sweets") Console.WriteLine(quantity * sweetsprice);
            else if (product == "peanuts") Console.WriteLine(quantity * peanutsprice);
        }
    }
}
