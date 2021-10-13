using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 个人电脑实现类
    /// </summary>
    public class ComputerDevice : IElectronicDevice
    {
        public string DeviceName => "笔记本";

        public string Start(IUser user, IPlayGame playGame)
        {
            string game = playGame.GetPlayGame();
            string userName = user.Get();
            return $"{userName}用{DeviceName}开始玩{game}";
        }
    }
}
