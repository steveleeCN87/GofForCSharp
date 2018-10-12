using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮...");
        }
    }
}
