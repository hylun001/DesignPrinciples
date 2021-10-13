using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 组织机构仓储实现类
    /// </summary>
    public class OrganizationRepository : IOrganizationRepository
    {
        /// <summary>
        /// 获取组织机构信息
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        public OrganizationInfo GetOrganizationInfo(int organizationId)
        {
            return new OrganizationInfo()
            {
                Id = organizationId,
                Name = $"部门{organizationId }"
            };
        }
    }
}
