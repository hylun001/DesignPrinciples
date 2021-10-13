using System;
using System.Collections.Generic;
using System.Text;

namespace 开闭原则
{
   public class User:IUser
    {
        public string Get()
        {
            return "张三";
        }
    }
}
