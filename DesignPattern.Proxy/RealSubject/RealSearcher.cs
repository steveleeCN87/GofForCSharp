using System;

namespace DesignPattern.Proxy.RealSubject
{
    /// <summary>
    /// 真是主题类：具体查询器
    /// </summary>
   public  class RealSearcher
    {
        /// <summary>
        /// 模拟查询商务信息
        /// </summary>
        /// <returns></returns>
        public string DoSearch(string userID, string keyword)
        {
            Console.WriteLine("{0} 使用关键词 {1}", userID, keyword);
            return "返回具体内容";
        }
    }
}
