using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <returns></returns>
        string Get();
    }
}
