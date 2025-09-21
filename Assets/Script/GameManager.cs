using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> farmAnimals;
    public List<Animal> animals;

    void Start()
    {
        (string name, int hunger, int happiness)[] animalData =
        {
            ("Azir",   10, 10),   // Chicken
            ("Alista", 15, 12),   // Cow
            ("Yuumi",  8,  14)    // Duck
        };

        for (int i = 0; i < farmAnimals.Count; i++)
        {
            Animal newAnimal = Instantiate(farmAnimals[i]);
            var data = animalData[i];
            newAnimal.Init(data.name, data.hunger, data.happiness);
            animals.Add(newAnimal);
        }

        Debug.Log($"Welcome to FarmSim! There are {animals.Count} animals living in HappyFarm.");

        foreach (Animal animal in animals)
        {
            animal.GetStatus();
            animal.MakeSound();
            animal.Feed0(2);
        }
    }
}






