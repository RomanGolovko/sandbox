using Ninject.Modules;
using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Concrete;

namespace SEO_Analyzer.BLL.Infrastructure
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
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
