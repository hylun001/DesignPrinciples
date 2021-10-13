using System;

namespace 迪米特法则
{
    class Program
    {
        /// <summary>
        /// 一个对象应当对其他对象尽可能少了解，做封装。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IConcurrentDictionary<string> dictionary = new ConcurrentDictionary<string>("testDic");
            dictionary.TryAdd(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

            int count = dictionary.Count;
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
