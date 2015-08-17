﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Garage.BLL.Abstract;
using Garage.BLL.Concrete;
using Garage.BLL.DTO;
using Ninject;

namespace Garage.WebUI.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
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
            kernel.Bind<IService<DriverDTO>>().To<DriverService>();
            kernel.Bind<IService<VehicleDTO>>().To<VehicleService>();
        }
    }
}