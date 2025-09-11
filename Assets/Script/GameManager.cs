using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chicken chicken;
    private Cow cow;

    void Start()
    {
        chicken = new Chicken("Chicky", 20, 15, 0);
        cow = new Cow("MooMoo", 25, 10, 1.5f);

        chicken.GetStatus();
        chicken.MakeSound();
        chicken.Feed("Corn");
        chicken.Sleep();
        chicken.GetStatus();

        Debug.Log("--------------------------");

        cow.GetStatus();
        cow.MakeSound();
        cow.Feed("Grass");
        cow.GetStatus();
    }
}
