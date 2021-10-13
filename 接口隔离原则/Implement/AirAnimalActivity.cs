using System;
using System.Collections.Generic;
using System.Text;

namespace 接口隔离原则
{
    /// <summary>
    /// 空中类动物活动
    /// </summary>
    public class AirAnimalActivity : BaseActivity, IForenoonActivity
    {
        public void Forenoon()
        {
            DataSource.Add("飞翔");
        }
    }
}
