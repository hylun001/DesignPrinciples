using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 玩游戏种类接口
    /// </summary>
    public interface IPlayGame
    {
        /// <summary>
        /// 游戏种类
        /// </summary>
        /// <returns></returns>
        string GetPlayGame();
    }
}
