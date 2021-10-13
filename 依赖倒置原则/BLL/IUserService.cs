using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 用户业务服务接口
    /// </summary>
    public interface IUserService
    {

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        List<UserInfo> GetUsers();

    }
}
