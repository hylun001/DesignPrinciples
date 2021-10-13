using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 手机电子设备
    /// </summary>
    public class PhoneDevice : IElectronicDevice
    {
        public string DeviceName => "手机";

        public string Start(IUser user, IPlayGame playGame)
        {
            string game = playGame.GetPlayGame();
            string userName = user.Get();
            return $"{userName}用{DeviceName}开始玩{game}";
        }
    }
}
