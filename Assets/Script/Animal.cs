using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }

    public void Init(string name, int hunger, int happiness)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int amount)
    {
        Happiness += amount;
    }


    public abstract void MakeSound();


    public virtual void Feed0(int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} กิน {amount} ชิ้น");
    }

    public virtual void Feed1(string foodType, int amount)
    {
        AdjustHunger(-amount);
        Debug.Log($"{Name} กินอาหาร {foodType} ปริมาณ {amount} ชิ้น");
    }

    public virtual void GetStatus()
    {
        Debug.Log($"{Name} | Hunger: {Hunger} | Happiness: {Happiness}");
    }
}




