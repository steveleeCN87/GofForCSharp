using System;

namespace DesignPattern.Prototype.PrototypeManager
{
    public interface OfficeDocument : ICloneable
    {
        new OfficeDocument Clone(); // 隐藏ICloneable的Clone接口方法定义
        void Display();
    }
}
