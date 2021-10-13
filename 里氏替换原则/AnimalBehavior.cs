using System;
using System.Collections.Generic;
using System.Text;

namespace 里氏替换原则
{
    /// <summary>
    /// 动物行为
    /// </summary>
    public class AnimalBehavior
    {
        /// <summary>
        /// 飞行速度
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        public double FlySpeed(IBird bird)
        {
            return 300 / bird.FlySpeed();
        }

        public bool CanSpeed(Penguin penguin)
        {
            return penguin.CanSpeed();
        }
    }
}
