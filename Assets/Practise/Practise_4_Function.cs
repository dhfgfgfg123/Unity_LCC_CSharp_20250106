using UnityEngine;

public class Practise_4_Function : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=#f33>{True()}</color>");
        Debug.Log($"<color=#f33>{False()}</color>");
    }

    private bool True()
    {
        return true;
    }

    private bool False()
    {
        return false;
    }
}
