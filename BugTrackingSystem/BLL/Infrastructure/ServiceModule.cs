using DataLayer.Abstract;
using DataLayer.Concrete;
using Ninject.Modules;

namespace BusinessLayer.Infrastructure
{
    public class ServiceModule : NinjectModule
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
