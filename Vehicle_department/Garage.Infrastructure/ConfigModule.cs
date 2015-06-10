using Ninject.Modules;
using Garage.Infrastructure.DataLayer.MSSQL;
using Garage.Infrastructure.DataLayer.LiteDB;


namespace Garage.Infrastructure
{
    public class ConfigModule : NinjectModule
    {
        bool LiteDb;
        bool MsSql;

        public ConfigModule(bool LiteDb, bool MsSql)
        {
            this.LiteDb = LiteDb;
            this.MsSql = MsSql;
        }
        public override void Load()
        {
            if (LiteDb)
                Bind<IRepository>().To<LiteDbRepository>();
            else if (MsSql)
                Bind<IRepository>().To<MsSqlRepository>();
        }
    }
}
