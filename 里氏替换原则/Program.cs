using System;

namespace 里氏替换原则
{
    class Program
    {
        /// <summary>
        /// 不要强行继承，如果继承就要完全实现。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //乌鸦
            AnimalBehavior crowBehavior = new AnimalBehavior();
            IBird crow = new Crow();
            Console.WriteLine($"乌鸦飞行速度: {crowBehavior.FlySpeed(crow)}");

            //麻雀
            AnimalBehavior sparrowBehavior = new AnimalBehavior();
            IBird sparrow = new Sparrow();
            Console.WriteLine($"麻雀飞行速度: {sparrowBehavior.FlySpeed(sparrow)}");

            //企鹅
            AnimalBehavior penguinBehavior = new AnimalBehavior();
            Penguin penguin = new Penguin();
            Console.WriteLine(penguinBehavior.CanSpeed(penguin) ? $"企鹅能飞" : $"企鹅不能飞");

            Console.ReadLine();
        }


    }
}
