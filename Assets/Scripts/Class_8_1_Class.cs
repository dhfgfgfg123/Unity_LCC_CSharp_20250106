using UnityEngine;

namespace Eason
{
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        // 類別 :
        // 用來定義一個物件以及他所擁有的資料與功能 (成員)

        private void Awake()
        {
            // 實例化 NPC 並儲存在 npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("傑克");
            Class_8_1_NPC npcEason = new Class_8_1_NPC("Eason", "你好啊~");

            npcJack.LogName();
            npcEason.LogName();
            npcJack.Talk();
            npcEason.Talk();

        }

    }
}
