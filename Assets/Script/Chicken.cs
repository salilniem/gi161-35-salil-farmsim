using UnityEngine;

public class Chicken : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Cluck Cluck!");
    }

    public override string Produce()
    {
        if (Happiness <= 50) return $"{Name} produced 0 eggs.";
        if (Happiness <= 79) return $"{Name} produced 2 eggs.";
        return $"{Name} produced 3 eggs.";
    }
}






