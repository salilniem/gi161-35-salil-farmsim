using UnityEngine;

public class Cow
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public float Milk { get; private set; }

    public Cow(string name, int hunger, int happiness, float milk)
    {
        Name = name;
        Hunger = ClampValue(hunger, 0, 50);
        Happiness = ClampValue(happiness, 0, 50);
        Milk = milk;
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
        Debug.Log($"{Name} says: Moo Moo!");
        AdjustHappiness(10);
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}...");
        AdjustHunger(-7);
        AdjustHappiness(4);
    }


    public void GetStatus()
    {
        Debug.Log($"[Cow Status] {Name} - Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }
}
