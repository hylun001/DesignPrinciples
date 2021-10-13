using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 组织机构信息类
    /// </summary>
    public class OrganizationInfo
    {
        /// <summary>
        /// 组织机构id
        /// </summary>
        public  int Id { get; set; }

        /// <summary>
        /// 组织机构名称
        /// </summary>
        public string Name { get; set; }
    }
}
