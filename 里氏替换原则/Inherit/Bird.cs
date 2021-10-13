using System;
using System.Collections.Generic;
using System.Text;

namespace 里氏替换原则
{
    /// <summary>
    /// 鸟类接口
    /// </summary>
    public interface IBird
    {
        //所有鸟类都应该具有飞行速度
        double FlySpeed();
    }
}
