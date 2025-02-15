using UnityEngine;

namespace Eason
{

    public class Practise_7_Property : MonoBehaviour
    {
        
        public float hp { get; } = 0;

        private void Awake()
        {
            
            if (hp <= 0)
            {
                Debug.Log(hp);
                Debug.Log($"<color=#f33>角色死亡</color>");
            }
        }
    }
}
