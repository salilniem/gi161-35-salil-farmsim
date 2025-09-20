using UnityEngine;

public class Cow : Animal
{
    public float Milk { get; private set; }

    public void Init(string name, int hunger, int happiness, float milk)
    {
        base.Init(name, hunger, happiness);
        Milk = milk;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} (วัว) ร้อง: Moo Moo!");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Milk: {Milk} liters");
    }
}



