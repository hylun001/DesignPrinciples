using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 组织机构仓储接口
    /// </summary>
    public interface IOrganizationRepository
    {

        /// <summary>
        /// 获取组织机构信息
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        OrganizationInfo GetOrganizationInfo(int organizationId);

    }
}
