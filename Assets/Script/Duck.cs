using UnityEngine;

public class Duck : Animal
{
    public int Feathers { get; private set; }

    public void Init(string name, int hunger, int happiness, int feathers)
    {
        base.Init(name, hunger, happiness);
        Feathers = feathers;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} (เป็ด) ร้อง: Quack Quack!");
    }

    public override void GetStatus()
    {
        base.GetStatus();
        Debug.Log($"Feathers: {Feathers}");
    }
}



