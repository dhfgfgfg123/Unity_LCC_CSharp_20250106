using UnityEngine;

public class Practise_4_Function : MonoBehaviour
{
    private void Awake()
    {
        True();
        False();
    }

    private void True()
    {
        Debug.Log($"<color=#f33>{1 == 1}</color>");
        
    }

    private void False()
    {
        Debug.Log($"<color=#f33>{1 != 1}</color>");
        

    }
}
