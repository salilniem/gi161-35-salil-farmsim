using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> farmAnimals;
    private List<Animal> animals = new List<Animal>();

    void Start()
    {
        SpawnAnimal<Chicken>(farmAnimals[0], "Azir", FoodType.Grain);
        SpawnAnimal<Cow>(farmAnimals[1], "Alista", FoodType.Hay);
        SpawnAnimal<Duck>(farmAnimals[2], "Yuumi", FoodType.Fish);

        Debug.Log($"Welcome to FarmSim! There are {animals.Count} animals living in HappyFarm.");

        foreach (var animal in animals)
        {
            animal.GetStatus();
            animal.MakeSound();

            Debug.Log($"Feeding {animal.Name} with its favorite food...");
            animal.Feed(FoodType.Grain, 3);
            Debug.Log($"{animal.Name} produced: {animal.Produce()}");

            Debug.Log($"Feeding {animal.Name} with Rotten Food...");
            animal.Feed(FoodType.RottenFood, 2);
            Debug.Log($"{animal.Name} produced: {animal.Produce()}");

            Debug.Log($"Feeding {animal.Name} with too many favorite Food...");
            animal.Feed(FoodType.Fish, 999);
            Debug.Log($"{animal.Name} produced: {animal.Produce()}");
        }
    }

    // Generic function for Spawn
    void SpawnAnimal<T>(Animal prefab, string name, FoodType favorite) where T : Animal
    {
        T instance = (T)Instantiate(prefab);
        instance.Init(name, favorite);
        animals.Add(instance);
    }
}








