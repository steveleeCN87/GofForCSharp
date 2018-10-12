using System;

namespace DesignPattern.Facade.Subsystem
{
    /// <summary>
    /// 文件读取类：子系统A
    /// </summary>
    public class FileReader
    {
        public string Read(string fileNameSrc)
        {
            Console.WriteLine("读取文件，获取明文：");
            string result = string.Empty;
            using (System.IO.FileStream fsRead = new System.IO.FileStream(fileNameSrc, System.IO.FileMode.Open))
            {
                int fsLen = (int)fsRead.Length;
                byte[] heByte = new byte[fsLen];
                int r = fsRead.Read(heByte, 0, heByte.Length);
                result = System.Text.Encoding.UTF8.GetString(heByte);
            }

            return result;
        }
    }
}
