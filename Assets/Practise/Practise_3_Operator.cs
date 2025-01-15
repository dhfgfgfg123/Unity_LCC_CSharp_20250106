using UnityEngine;

public class Practise_3_Operator : MonoBehaviour
{
    private void Awake()
    {
        Count();
    }

    private void Count()
    {
        Debug.Log($"<color=#f33>{6 / 2 * (1 + 2)}</color>");
    }
}

