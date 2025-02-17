using System.Net.NetworkInformation;
using UnityEngine;

namespace Eason
{

    public class Practise_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_Boss goblinKing = new Practice_8_Boss("哥布林王", "哥布林斬擊", 1000);
            Practice_8_Boss skeletonKing = new Practice_8_Boss("骷髏王", "大腿骨衝擊", 1500);

            goblinKing.Data();
            skeletonKing.Data();
        }
    }
}
