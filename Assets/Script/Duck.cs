using UnityEngine;

public class Duck : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} says Quack Quack!");
    }

    public override string Produce()
    {
        if (Happiness <= 50) return $"{Name} produced 0 feathers";
        if (Happiness <= 79) return $"{Name} produced 2 feathers";
        return $"{Name} produced 3 feathers";
    }
}



