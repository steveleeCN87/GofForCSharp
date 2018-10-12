namespace DesignPattern.Interpreter.Expression
{
    /// <summary>
    /// 终结符表达式：距离解释
    /// </summary>
    public class DistanceNode : AbstractNode
    {
        private string distance;

        public DistanceNode(string distance)
        {
            this.distance = distance;
        }

        // 距离表达式的解释操作
        public override string Interpret()
        {
            return this.distance;
        }
    }
}
