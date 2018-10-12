using DesignPattern.Observer.Subject;

namespace DesignPattern.Observer.Observer
{
    /// <summary>
    /// 抽象观察类 - IObserver接口
    /// </summary>
    public interface IObserver
    {
        string Name { get; set; }
        void Help();                                                                // 声明支援盟友的方法
        void BeAttacked(AllyControlCenter acc);     // 声明遭受攻击的方法
    }
}
