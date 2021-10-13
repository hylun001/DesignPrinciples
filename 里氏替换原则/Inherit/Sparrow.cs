using System;
using System.Collections.Generic;
using System.Text;

namespace 里氏替换原则
{
    /// <summary>
    /// 麻雀
    /// </summary>
    public class Sparrow : IBird
    {
        /// <summary>
        /// 飞行速度
        /// </summary>
        /// <returns></returns>
        public double FlySpeed()
        {
            return 10.5;
        }
    }
}
