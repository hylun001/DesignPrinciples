using System;
using System.Collections.Generic;
using Autofac;

namespace 依赖倒置原则
{
    class Program
    {
        /// <summary>
        /// 高层模块不依赖底层模块，抽象不应该依赖细节，细节应该依赖抽象，达到解耦。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<OrganizationRepository>().As<IOrganizationRepository>();
            
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            IContainer container = builder.Build();

            IUserService userService = container.Resolve<IUserService>();
            List<UserInfo> users = userService.GetUsers();
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(users));

            Console.ReadLine();
        }
    }
}
