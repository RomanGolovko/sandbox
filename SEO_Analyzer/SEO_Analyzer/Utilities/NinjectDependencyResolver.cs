using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using SEO_Analyzer.BLL.Abcstract;
using SEO_Analyzer.BLL.Concrete;

namespace SEO_Analyzer.Utilities
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
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
            kernel.Bind<IResultService>().To<ResultService>();
        }
    }
}