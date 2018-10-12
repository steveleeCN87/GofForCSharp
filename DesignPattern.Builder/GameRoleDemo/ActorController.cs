namespace DesignPattern.Builder.GameRoleDemo
{
    /// <summary>
    /// 游戏角色创建控制器：指挥者(Director)
    /// </summary>
    public class ActorController
    {
        /// <summary>
        /// 逐步构建复杂产品对象
        /// </summary>
        public Actor Construct(ActorBuilder builder)
        {
            builder.BuildType();
            builder.BuildSex();
            builder.BuildFace();
            builder.BuildCostume();
            builder.BuildHairStyle();

            return builder.CreateActor(); ;
        }
    }
}
