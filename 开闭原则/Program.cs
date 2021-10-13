using System;

namespace 开闭原则
{
    class Program
    {
        /// <summary>
        /// 高度抽象。只做模块扩展，不做模块本身代码修改，尽量在设计时考虑全面，改动会比较大。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //张三用手机玩王者荣耀
            IUser user = new User();
            IPlayGame aovGame = new AOVGame();

            IElectronicDevice phone = new PhoneDevice();
            Console.WriteLine(phone.Start(user, aovGame));

            //张三用笔记本玩倩女幽魂
            IUser user1 = new User();
            IPlayGame acgsGame = new ACGSGame();

            IElectronicDevice computer = new ComputerDevice();
            Console.WriteLine(computer.Start(user1, acgsGame));

            //扩展
            //电子设备
            //游戏

            Console.ReadLine();
        }
    }
}
