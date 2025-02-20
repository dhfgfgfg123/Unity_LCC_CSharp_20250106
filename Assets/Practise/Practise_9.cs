using Eason.Tools;
using System;
using UnityEngine;

namespace Eason
{

    public class Practise_9 : MonoBehaviour
    {

        private void Awake()
        {
            decimal count = -999.321m;
            SByte decimalToSbyte = Convert.ToSByte(count);
            LogSystem.LogWithColor(decimalToSbyte, "#f33");
            LogSystem.LogWithColor(decimalToSbyte.GetType(), "#f33");
        }
    }
}
