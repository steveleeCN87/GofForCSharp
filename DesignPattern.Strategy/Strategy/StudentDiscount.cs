using System;

namespace DesignPattern.Strategy.Strategy
{
    /// <summary>
    /// 具体策略类：学生票折扣StudentDiscount
    /// </summary>
    public class StudentDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("学生票：");
            return price * 0.8;
        }
    }
}
