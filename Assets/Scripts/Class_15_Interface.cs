using Eason.Tools;
using UnityEngine;

namespace Eason.Class_15
{
    /// <summary>
    /// 介面 Interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object invertoryFirst;

        private void Awake()
        {
            int random = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機 : {random}", "#f33");

            if (random == 0) invertoryFirst = new Prop();
            else if (random == 1) invertoryFirst = new Equipment();
            else if (random == 2) invertoryFirst = new Map();
        }

        private void Update()
        {
            // 按下數字鍵 1 可以使用地一個物品
            // 如果第一格是道具，就使用道具
            if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();

            // 如果第一格是裝備，就使用裝備
            else if (invertoryFirst is Equipment) ((Equipment)invertoryFirst).Use();

            // 如果第一格是地圖，就使用地圖
            else if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

            // 當遊戲的物品種類變多時，這邊的判斷會很恐怖...
        }
    }

    public class Prop
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用道具，回復體力", "#f96");
        }
    }

    public class Equipment
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，裝到對應位置", "#f96");
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#f96");
        }
    }
}
