using DesignPattern.AbstractFactory.AbstractFactory;
using DesignPattern.AbstractFactory.AbstractProduct;
using DesignPattern.AbstractFactory.ConcreteProduct;

namespace DesignPattern.AbstractFactory.ConcreteFactory
{
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}
