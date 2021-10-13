using System;
using System.Collections.Generic;
using System.Text;

namespace 接口隔离原则
{
    /// <summary>
    /// 海洋类动物活动
    /// </summary>
    public class OceanAnimalActivity : BaseActivity, IAfternoonActivity
    {
        public void Afternoon()
        {
            DataSource.Add("食草");
            DataSource.Add("拉屎");
        }
    }
}
