using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Chicken chicken;
    private Cow cow;

    void Start()
    {
        // ���ҧ�ѵ��
        chicken = new Chicken("Chicky", 20, 30, 0);
        cow = new Cow("MooMoo", 15, 25, 5.0f);

        // ���¡ method �ͧ Chicken
        chicken.MakeSound();
        chicken.Feed("corn");
        chicken.Sleep();

        // ���¡ method �ͧ Cow
        cow.MakeSound();
        cow.Feed("grass");
    }
}

