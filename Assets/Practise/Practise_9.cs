using Eason.Tools;
using System;
using UnityEngine;

namespace Eason
{

    public class Practise_9 : MonoBehaviour
    {

        private void Awake()
        {
            float count = -999.321f;
            sbyte sbyteNumber = (sbyte)count;
            LogSystem.LogWithColor(sbyteNumber, "#f33");
            
           
        }
    }
}
