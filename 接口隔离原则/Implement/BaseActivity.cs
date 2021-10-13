using System;
using System.Collections.Generic;
using System.Text;

namespace 接口隔离原则
{
    /// <summary>
    /// 活动基类
    /// </summary>
    public class BaseActivity : IActivity
    {
        public BaseActivity()
        {
            DataSource ??= new List<string>();
        }
        /// <summary>
        /// 数据源
        /// </summary>
        protected List<string> DataSource { get; set; }

        public void Do()
        {
            (this as IForenoonActivity)?.Forenoon();
            (this as IAfternoonActivity)?.Afternoon();
            (this as INightActivity)?.Night();
        }

        public List<string> GetActivities()
        {
            return DataSource;
        }
    }
}
