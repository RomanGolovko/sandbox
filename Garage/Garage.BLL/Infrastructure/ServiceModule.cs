using Ninject.Modules;

using Garage.DAL.Interfaces;
using Garage.DAL.Repositories;

namespace Garage.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
