using System;
using UnityEngine;

namespace Eason
{

    public class Practise_5_Selection : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 100)]
        public int hp = 100;


        private void Update()
        {
            switch (hp)
            {
                case >= 80:
                    Debug.Log("<color=#ff3>血量安全</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#ff3>健康狀態有狀況</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#ff3>警告，快喝水</color>");
                    break;
                case >= 10:
                    Debug.Log("<color=#ff3>快死掉了</color>");
                    break;
                case  0:
                    Debug.Log("<color=#ff3>你已經死了</color>");
                    break;
            }
        }
    }
}

