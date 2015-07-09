﻿using System;

using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

using Garage.Domain.Abstract;
using Garage.Domain.Concrete;
using Garage.Domain.Entities;

namespace Garage.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера
            // используя его тип
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IRepository<Driver>>().To<DriversRepository>();
        }
    }
}
