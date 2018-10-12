namespace DesignPattern.Interpreter.Expression
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class AbstractNode
    {
        public abstract string Interpret();
    }
}
