using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮...");
        }
    }
}
