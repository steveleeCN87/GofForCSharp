namespace DesignPattern.Mediator.Colleague
{
    /// <summary>
    /// 抽象同事类：抽象组件
    /// </summary>
    public abstract class Component
    {
        protected Mediator.Mediator mediator;

        public void SetMediator(Mediator.Mediator mediator)
        {
            this.mediator = mediator;
        }

        // 转发调用
        public void Changed()
        {
            mediator.ComponenetChanged(this);
        }

        public abstract void Update();
    }
}
