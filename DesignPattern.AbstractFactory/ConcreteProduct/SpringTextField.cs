using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框文本框...");
        }
    }
}
