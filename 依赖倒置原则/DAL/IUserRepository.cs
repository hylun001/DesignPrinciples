using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 用户仓储接口
    /// </summary>
    public interface IUserRepository
    {
        List<UserInfo> GetUsers();
    }
}
