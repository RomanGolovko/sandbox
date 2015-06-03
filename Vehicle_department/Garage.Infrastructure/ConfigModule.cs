using Ninject.Modules;

namespace Garage.Infrastructure
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<MsSqlRepository>();
        }
    }
}
