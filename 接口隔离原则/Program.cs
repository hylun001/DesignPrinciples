using System;
using System.Collections.Generic;

namespace 接口隔离原则
{
    class Program
    {
        /// <summary>
        /// 客户端不应该依赖它不需要的接口；一个类对另一个类的依赖应该建立在最少接口上。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IActivity airActivity = new AirAnimalActivity();
            airActivity.Do();
            List<string> airActivities = airActivity.GetActivities();
            Console.WriteLine($"海: {string.Join(",", airActivities)}");

            IActivity landActivity = new LandAnimalActivity();
            landActivity.Do();
            List<string> landActivities = landActivity.GetActivities();
            Console.WriteLine($"陆: {string.Join(",", landActivities)}");

            IActivity oceanActivity = new OceanAnimalActivity();
            oceanActivity.Do();
            List<string> oceanActivities = oceanActivity.GetActivities();
            Console.WriteLine($"空: {string.Join(",", oceanActivities)}");

            Console.ReadLine();
        }
    }
}
