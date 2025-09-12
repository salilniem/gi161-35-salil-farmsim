using UnityEngine;

public class Chicken
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Eggs { get; private set; }
    public string Sound { get; private set; }

    public Chicken(string name, int hunger, int happiness, int eggs)
    {
        Name = name; Hunger = hunger; Happiness = happiness; Eggs = eggs;
        Sound = "Aek E Aek AEKK!";
    }

    public void AdjustHunger(int value)
    {
        Hunger += value;
        if (Hunger < 0) Hunger = 0;
        if (Hunger > 50) Hunger = 50;
        Debug.Log($"{Name}'s Hunger: {Hunger}");
    }

    public void AdjustHappiness(int value)
    {
        Happiness += value;
        if (Happiness < 0) Happiness = 0;
        if (Happiness > 50) Happiness = 50;
        Debug.Log($"{Name}'s Happiness: {Happiness}");
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says: {Sound}");
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}.");
        AdjustHunger(-5);
        AdjustHappiness(5);
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is sleeping...");
        AdjustHunger(2);
        AdjustHappiness(3);
    }
}

