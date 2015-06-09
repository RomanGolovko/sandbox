using Ninject.Modules;
using Garage.Infrastructure.DataLayer.MSSQL;
using Garage.Infrastructure.DataLayer.LiteDB;


namespace Garage.Infrastructure
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IRepository>().To<MsSqlRepository>();
            Bind<IRepository>().To<LiteDbRepository>();
        }
    }
}
