using UnityEngine;

public class Chicken : Animal
{
    public int Eggs { get; private set; }

    public void Init(string name, int hunger, int happiness, int eggs)
    {
        base.Init(name, hunger, happiness);
        Eggs = eggs;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} (ไก่) ร้อง: Aek E Aek AEKK!");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Eggs: {Eggs}");
    }
}






