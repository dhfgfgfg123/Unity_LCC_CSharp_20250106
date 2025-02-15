using System.Net.NetworkInformation;
using UnityEngine;

namespace Eason
{

    public class Practise_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practise_8_Boss goblinKing = new Practise_8_Boss("哥布林王", "哥布林斬擊", 1000);
            Practise_8_Boss skeletonKing = new Practise_8_Boss("骷髏王", "大腿骨衝擊", 1500);

            goblinKing.Data();
            skeletonKing.Data();
        }
    }
}
