using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 平板电脑
    /// </summary>
    public class TabletDevice : IElectronicDevice
    {
        public string DeviceName => "平板电脑";

        public string Start(IUser user, IPlayGame playGame)
        {
            string game = playGame.GetPlayGame();
            string userName = user.Get();
            return $"{userName}用{DeviceName}开始玩{game}";
        }
    }
}
