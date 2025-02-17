using UnityEngine;

namespace Eason
{

    public class Practice_8_Boss
    {
        private string name;
        private string skill;
        private float hp;

        public Practice_8_Boss(string _name, string _skill, float _hp)
        {
            name =  _name;
            skill = _skill;
            hp = _hp;
        }

        public void Data()
        {
            Debug.Log($"<color=#3f3>名稱 : {name}, 大絕招名稱 : {skill}, 血量 : {hp}");
        }
    }
}
