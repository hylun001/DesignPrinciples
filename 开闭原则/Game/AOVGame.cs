using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 王者荣耀
    /// </summary>
    public class AOVGame: IPlayGame
    {
        public string GetPlayGame()
        {
            return "王者荣耀";
        }
    }
}
