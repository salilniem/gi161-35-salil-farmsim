using System;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
{
    Hay,        // Cow
    Grain,      // Chicken
    Fish,       // Duck
    RottenFood, // อาหารเสีย
    AnimalFood  // อาหารทั่วไป
}

public abstract class Animal : MonoBehaviour
{
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    protected FoodType FavoriteFood { get; set; }

    private const int MinValue = 0;
    private const int MaxValue = 100;

    public void Init(string name, FoodType favorite)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
        FavoriteFood = favorite;
    }

    protected void AdjustHunger(int amount)
    {
        Hunger = Mathf.Clamp(Hunger + amount, MinValue, MaxValue);
    }

    protected void AdjustHappiness(int amount)
    {
        Happiness = Mathf.Clamp(Happiness + amount, MinValue, MaxValue);
    }

    public abstract void MakeSound();
    public abstract string Produce();

    public virtual void Feed(int foodAmount)
    {
        AdjustHunger(-foodAmount);
        AdjustHappiness(foodAmount / 2);
        Debug.Log($"{Name} ate food. Hunger: {Hunger}, Happiness: {Happiness}");
    }

    public virtual void Feed(FoodType food, int foodAmount)
    {
        if (food == FoodType.RottenFood)
        {
            AdjustHappiness(-20);
            Debug.Log($"{Name} ate RottenFood! Happiness: {Happiness}");
            return;
        }

        if (food == FavoriteFood)
        {
            AdjustHunger(-foodAmount);
            AdjustHappiness(15);
            Debug.Log($"{Name} is very happy eating {food}! Hunger: {Hunger}, Happiness: {Happiness}");
        }
        else
        {
            Feed(foodAmount);
        }
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} -> Hunger: {Hunger}, Happiness: {Happiness}");
    }
}



