using System;
using System.Collections.Generic;
using System.Text;

namespace 接口隔离原则
{
    /// <summary>
    /// 陆地类动物活动
    /// </summary>
    public class LandAnimalActivity : BaseActivity, IForenoonActivity, IAfternoonActivity, INightActivity
    {
        public void Forenoon()
        {
            DataSource.Add("吃饭");
        }

        public void Afternoon()
        {
            DataSource.Add("打豆豆");
        }

        public void Night()
        {
            DataSource.Add("睡觉");
        }
    }
}
