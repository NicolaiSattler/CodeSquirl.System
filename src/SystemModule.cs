using Autofac;

namespace CodeSquirl.System
{
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IRepository>();
            builder.RegisterType<IEntity>().As<Entity>();
        }
    }
}