using UnityEngine;

public class Chicken
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Eggs { get; private set; }

    public Chicken(string name, int hunger, int happiness, int eggs)
    {
        Name = name;
        Hunger = ClampValue(hunger, 0, 50);
        Happiness = ClampValue(happiness, 0, 50);
        Eggs = eggs;
    }

    private int ClampValue(int value, int min, int max)
    {
        return (value < min) ? min : (value > max) ? max : value;
    }

    public void AdjustHunger(int amount)
    {
        Hunger = ClampValue(Hunger + amount, 0, 50);
        Debug.Log($"{Name}'s Hunger: {Hunger}");
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = ClampValue(Happiness + amount, 0, 50);
        Debug.Log($"{Name}'s Happiness: {Happiness}");
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: Aek E Aek Aek!");
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}...");
        AdjustHunger(-5);
        AdjustHappiness(3);
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is sleeping...");
        AdjustHunger(2);
        AdjustHappiness(5);
    }

    public void GetStatus()
    {
        Debug.Log($"[Chicken Status] {Name} - Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }
}