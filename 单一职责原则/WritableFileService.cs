using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace 单一职责原则
{
    /// <summary>
    /// 写文件
    /// </summary>
    public class WritableFileService
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public Task<bool> DeletedAsync(string filePath)
        {
            return Task.Run(() =>
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                return false;
            });
        }

        /// <summary>
        /// 重命名文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="newFileName"></param>
        /// <returns></returns>
        public Task<bool> Rename(string filePath, string newFileName)
        {
            return Task.Run(() =>
            {
                if (File.Exists(filePath))
                {
                    File.Copy(filePath, newFileName);
                    return true;
                }

                return false;
            });

        }

        /// <summary>
        /// 追加文件内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public Task<bool> AppendContent(string filePath, string content)
        {
            return Task.Run(() =>
            {
                string directory = Path.GetDirectoryName(filePath);
                if (Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                File.WriteAllText(filePath, content);
                return true;
            });

        }
    }
}
