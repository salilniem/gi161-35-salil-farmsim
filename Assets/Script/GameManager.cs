using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> farmAnimals; 
    public List<Animal> animals;

    void Start()
    {
        Chicken chicken1 = (Chicken)Instantiate(farmAnimals[0]);
        chicken1.Init("Azir", 10, 10, 0);
        animals.Add(chicken1);

        Cow cow1 = (Cow)Instantiate(farmAnimals[1]);
        cow1.Init("Alista", 10, 10, 0);
        animals.Add(cow1);

        Duck duck1 = (Duck)Instantiate(farmAnimals[2]);
        duck1.Init("Yuumi", 10, 10, 0);
        animals.Add(duck1);

        Debug.Log($"Welcome to FarmSim! There are {animals.Count} animals living in HappyFarm.");

        foreach (Animal animal in animals)
        {
            animal.GetStatus();
            animal.MakeSound();
            animal.Feed0(2);
        }
    }
}




