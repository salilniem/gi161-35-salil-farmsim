using UnityEngine;

public class Cow
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public float Milk { get; private set; }
    public string Sound { get; private set; }

    public Cow(string name, int hunger, int happiness, float milk)
    {
        Name = name; Hunger = hunger; Happiness = happiness; Milk = milk;
        Sound = "Moo!";
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
        AdjustHappiness(10); // Moo แล้วแฮปปี้ขึ้น
    }

    public void Feed(string food)
    {
        Debug.Log($"{Name} is eating {food}.");
        AdjustHunger(-8);
        AdjustHappiness(4);
    }
}
