using System;
using System.Threading.Tasks;

namespace 单一职责原则
{
    class Program
    {
        /// <summary>
        /// 一个模块只做一件事。 不能过渡细分，会带来复杂性
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            string filePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/aaa.txt";
            WritableFileService writableFileService = new WritableFileService();
            bool succeed = await writableFileService.AppendContent(filePath, "hello word");
            if (succeed)
            {
                ReadableFileService readableFileService = new ReadableFileService();
                string content = await readableFileService.ReadContent(filePath);
                Console.WriteLine(content);
            }

            Console.ReadLine();
        }
    }
}
