using System;

namespace DesignPattern.Command.Receiver
{
    /// <summary>
    /// 请求接受者：帮助文档处理类
    /// </summary>
    public class HelpHandler
    {
        public void Display()
        {
            Console.WriteLine("正在显示帮助文档...");
        }
    }
}
