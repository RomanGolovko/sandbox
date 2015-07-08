using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Garage.BLL.Interfaces;
using Garage.BLL.Services;
using Ninject;

namespace Garage.Web.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IDriverService>().To<DriverService>();
        }
    }
}