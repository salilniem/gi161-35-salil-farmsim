using UnityEngine;

public class Cow : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Moo!");
    }

    public override string Produce()
    {
        if (Happiness > 70)
        {
            int milk = Happiness / 10;
            Debug.Log($"{Name} produced {milk} units of Milk!");
            return $"Total Milk: {milk} units";
        }
        return $"{Name} is not happy enough to produce milk.";
    }
}



