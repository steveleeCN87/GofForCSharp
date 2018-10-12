using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SummerComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框下拉框...");
        }
    }
}
