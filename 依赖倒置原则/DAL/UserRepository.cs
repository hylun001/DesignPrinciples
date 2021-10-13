using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 用户仓储类
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUsers()
        {
            return new List<UserInfo>()
            {
                {
                    new UserInfo(){Id = 1,Name="张三"}
                },
                {
                    new UserInfo(){Id = 2,Name="李四"}
                },
                {
                    new UserInfo(){Id = 3,Name="王五"}
                }
            };
        }
    }
}
