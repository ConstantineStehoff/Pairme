using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pairme.Services;
using System.Web.Mvc;
using Pairme.Infrastructure;

namespace Pairme.App_Start
{
    public class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);

            DependencyResolver.SetResolver(new PairmeUnityDependencyResolver(container));
        }

        public static void registerServices(IUnityContainer container)
        {
            container.RegisterType<IAccountService, AccountService>();
        }
    }
}