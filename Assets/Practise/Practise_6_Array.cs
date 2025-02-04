using UnityEngine;

namespace Eason
{

    public class Practise_6_Array : MonoBehaviour
    {

        public string[,,] shop =
    {
        //第一頁
        { {"皮卡丘","妙蛙種子","卡比獸"} },
        //第二頁
        { {"藍寶","菇菇寶貝","緞帶肥肥"} },
        //第三頁
        { {"艾希","蓋倫","凱特林"} }

      };

        private void Start()
        {
            Debug.Log($"<color=#f33>{shop[0, 0, 0]}</color>");
            Debug.Log($"<color=#f33>{shop[1, 0, 1]}</color>");
            Debug.Log($"<color=#f33>{shop[2, 0, 1]}</color>");

            Debug.Log($"<color=#f33>{shop[1, 0, 2]}</color>");
        }
    }
}
