using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 接口隔离原则
{
    /// <summary>
    /// 一天活动
    /// </summary>
    public interface IActivity
    {
        /// <summary>
        /// 开始执行
        /// </summary>
        void Do();

        /// <summary>
        /// 获取执行活动列表
        /// </summary>
        /// <returns></returns>
        List<string> GetActivities();
    }
}
