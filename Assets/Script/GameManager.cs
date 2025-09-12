using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chicken chicken;
    private Cow cow;

    void Start()
    {
        // สร้างสัตว์
        chicken = new Chicken("Chicky", 20, 30, 0);
        cow = new Cow("MooMoo", 15, 25, 5.0f);

        // เรียก method ของ Chicken
        chicken.MakeSound();
        chicken.Feed("corn");
        chicken.Sleep();

        // เรียก method ของ Cow
        cow.MakeSound();
        cow.Feed("grass");
    }
}

