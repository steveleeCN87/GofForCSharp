using System;
using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.ConcreteProduct
{
    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框下拉框...");
        }
    }
}
