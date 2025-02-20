using Eason.Tools;
using UnityEngine;

namespace Eason
{

    public class Practise_10 : MonoBehaviour
    {
        private void Awake()
        {
            Item potion1 = new Item("紅水");
            Potion potion2 = new Potion("藍水", 100);
            Equipment equipment1 = new Equipment("頭盔", 10);

            potion1.Use();
            potion2.Use();
            equipment1.Use();
        }
    }

    public class Item
    {
        public string name;
        
        public Item() { }
        public Item(string _name)
        {
            name = _name;
        }
        public virtual void Use()
        {
            LogSystem.LogWithColor($"使用 : {name}", "#f33");
        }

    }

    public class Potion : Item
    {
        public string name;
        public float heal;

        public Potion(string _name, float _heal)
        {
            name = _name;
            heal = _heal;
        }

        public void Use()
        {
            LogSystem.LogWithColor($"使用 : {name} 補充 : {heal} 點魔力", "#f33");
        }
    }

    public class Equipment : Item
    {
        public string name;
        public float weight;

        public Equipment(string _name, float _weight)
        {
            name = _name;
            weight = _weight;
        }

        public override void Use()
        {
            LogSystem.LogWithColor($"裝備 : {name} 需承受 : {weight} 重量", "#f33");
        }
    }
}
