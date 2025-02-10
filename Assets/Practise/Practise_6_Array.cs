using UnityEngine;

namespace Eason
{

    public class Practise_6_Array : MonoBehaviour
    {

        public string[,,] charaterName =
    {
        //第一頁
        { {"皮卡丘","妙蛙種子","卡比獸"},{"雷丘","噴火龍","水箭龜" } },
        //第二頁
        { {"藍寶","菇菇寶貝","緞帶肥肥"}, {"木妖","斧木妖","黑木妖" } },
        //第三頁
        { {"艾希","蓋倫","凱特林"},{"維加","漢默丁格","薩科" } }

      };

        private void Start()
        {
            Debug.Log($"<color=#f33>{charaterName[0, 0, 0]}</color>");
            Debug.Log($"<color=#f33>{charaterName[1, 0, 1]}</color>");
            Debug.Log($"<color=#f33>{charaterName[2, 0, 1]}</color>");

            Debug.Log($"<color=#f33>{charaterName[1, 0, 2]}</color>");
        }
    }
}
