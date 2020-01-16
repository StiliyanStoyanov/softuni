using System;

namespace _08_CalorieCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int ingridientsToRead = int.Parse(Console.ReadLine());

            int cheeseCalories = 0;
            int tomatoSauceCalories = 0;
            int salamiCalories = 0;
            int pepperCalories = 0;

            for (int i = 1; i <= ingridientsToRead; i++)
            {
                string ingridientType = Console.ReadLine().ToLower();
                if (ingridientType == "cheese")
                {
                    cheeseCalories += 500;
                }
                else if (ingridientType == "tomato sauce")
                {
                    tomatoSauceCalories += 150;
                }
                else if (ingridientType == "salami")
                {
                    salamiCalories += 600;
                }
                else if (ingridientType == "pepper")
                {
                    pepperCalories += 50;
                }
            }
            int totalCalories = cheeseCalories + tomatoSauceCalories + salamiCalories + pepperCalories;
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
