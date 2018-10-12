using DesignPattern.AbstractFactory.AbstractProduct;

namespace DesignPattern.AbstractFactory.AbstractFactory
{
    public interface ISkinFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        IComboBox CreateComboBox();
    }
}
