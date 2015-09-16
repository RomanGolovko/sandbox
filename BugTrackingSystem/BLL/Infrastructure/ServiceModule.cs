using DAL.Abstract;
using DAL.Concrete;
using Ninject.Modules;

namespace BLL.Infrastructure
{
    class ServiceModule : NinjectModule
    {
        string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IBugReportRepository>().To<EFBugReportRepository>().WithConstructorArgument(connectionString);
        }
    }
}
