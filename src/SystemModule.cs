using Autofac;

namespace CodeSquirrel.System
{
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IEntity>().As<Entity>();
        }
    }
}