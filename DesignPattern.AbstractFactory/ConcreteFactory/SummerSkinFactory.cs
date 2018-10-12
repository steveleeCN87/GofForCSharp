using DesignPattern.AbstractFactory.AbstractFactory;
using DesignPattern.AbstractFactory.AbstractProduct;
using DesignPattern.AbstractFactory.ConcreteProduct;

namespace DesignPattern.AbstractFactory.ConcreteFactory
{
    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
