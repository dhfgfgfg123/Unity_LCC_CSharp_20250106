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

    public class Practice_8_Boss
    {
        private string name;
        private string skill;
        private float hp;

        public Practice_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }

        public void Data()
        {
            Debug.Log($"<color=#3f3>名稱 : {name}, 大絕招名稱 : {skill}, 血量 : {hp}");
        }
    }
}
