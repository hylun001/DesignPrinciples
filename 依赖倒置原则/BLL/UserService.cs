using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖倒置原则
{
    /// <summary>
    /// 用户业务服务实现
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository m_userRepository;

        private readonly IOrganizationRepository m_organizationRepository;

        /// <summary>
        /// 高层模块不依赖底层模块具体实现
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="organizationRepository"></param>
        public UserService(IUserRepository userRepository, IOrganizationRepository organizationRepository)
        {
            m_userRepository = userRepository;
            m_organizationRepository = organizationRepository;
        }

        public List<UserInfo> GetUsers()
        {
            List<UserInfo> users = m_userRepository.GetUsers();

            OrganizationInfo organizationInfo;
            int count = users.Count;
            for (int i = 0; i < count; i++)
            {
                organizationInfo = m_organizationRepository.GetOrganizationInfo(i);
                users[i].OrganizationId = organizationInfo.Id;
                users[i].OrganizationName = organizationInfo.Name;
            }

            return users;
        }
    }
}
