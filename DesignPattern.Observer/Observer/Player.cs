using System;
using DesignPattern.Observer.Subject;

namespace DesignPattern.Observer.Observer
{
    /// <summary>
    /// 具体观察者类：战队成员
    /// </summary>
    public class Player : IObserver
    {
        public string Name
        {
            get;
            set;
        }

        public void BeAttacked(AllyControlCenter acc)
        {
            Console.WriteLine("{0}：我正被攻击，速来援救！", this.Name);
            // 调用战队控制中心类的通知方法来通知盟友
            acc.NotifyObserver(this.Name);
        }

        public void Help()
        {
            Console.WriteLine("{0} ：坚持住，立马来救你！", this.Name);
        }
    }
}
