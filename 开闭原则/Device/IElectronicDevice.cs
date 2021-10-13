using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 电子设备接口
    /// </summary>
    public interface IElectronicDevice
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        string DeviceName { get; }

        /// <summary>
        /// 开始玩游戏
        /// </summary>
        ///<param name="user"></param>
        /// <param name="playGame"></param>
        string Start(IUser user,IPlayGame playGame);
    }
}
