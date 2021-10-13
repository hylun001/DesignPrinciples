using System;
using System.Collections.Generic;
using System.Text;

namespace 里氏替换原则
{
    /// <summary>
    /// 乌鸦
    /// </summary>
    public class Crow : IBird
    {
        /// <summary>
        /// 飞行速度
        /// </summary>
        /// <returns></returns>
        public double FlySpeed()
        {
            return 10.2;
        }
    }
}
