using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 倩女幽魂游戏
    /// </summary>
    public class ACGSGame:IPlayGame
    {
        public string GetPlayGame()
        {
            return "倩女幽魂";
        }
    }
}
