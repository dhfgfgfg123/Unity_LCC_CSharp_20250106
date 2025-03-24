using Eason.Tools;
using System;
using UnityEngine;

namespace Eason.Class_19.Event
{
    /// <summary>
    /// 背景音樂管理器
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        private void Awake()
        {
            // 步驟 3. 其他系統訂閱事件
            class_19_event.onDead += ChangeBgm;
            class_19_event.onDeadAction += ChangeBgmViaHp;
        }

        private void ChangeBgmViaHp(string arg1, float arg2)
        {
            LogSystem.LogWithColor($"{arg1}, | 的血量 : {arg2}", "#78f");
            if (arg2 <= -5) LogSystem.LogWithColor("變更為遊戲結束音樂", "#f777");
        }

        private void ChangeBgm()
        {
            LogSystem.LogWithColor("變更音樂", "#3f3");
        }
    }
}

