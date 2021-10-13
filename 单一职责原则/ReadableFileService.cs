using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace 单一职责原则
{
    /// <summary>
    /// 读文件
    /// </summary>
    public class ReadableFileService
    {

        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Task<bool> Exist(string filePath)
        {
            return Task.Run(() => File.Exists(filePath));
        }

        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Task<long> GetFileSize(string filePath)
        {
            return Task.Run(() =>
            {
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            });
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Task<string> ReadContent(string filePath)
        {
            return File.ReadAllTextAsync(filePath);
        }
    }
}
