using System;

class CharacterStats
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maximumHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maximumEnergy = int.Parse(Console.ReadLine());

        if (currentHealth > maximumHealth) currentHealth = maximumHealth;
        if (currentEnergy > maximumEnergy) currentEnergy = maximumEnergy;

        int damageTaken = maximumHealth - currentHealth;
        int energyUsed = maximumEnergy - currentEnergy;

        string healthLeft = new string('|', currentHealth);
        string damageTaken2 = new string('.', damageTaken);
        string energyLeft = new string('|', currentEnergy);
        string energyUsed2 = new string('.', energyUsed);
        if (maximumHealth >= currentHealth && maximumEnergy >= currentEnergy)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthLeft}{damageTaken2}|");
            Console.WriteLine($"Energy: |{energyLeft}{energyUsed2}|");
        }
        else if (maximumHealth < 0 || maximumEnergy < 0)
        {
            Console.WriteLine("ERROR");
        }
    }
}
