using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框文本框...");
        }
    }
}
