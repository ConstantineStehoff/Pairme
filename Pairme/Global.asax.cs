using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using System.Web.ModelBinding;
using System.Web.Optimization;
using System.Web.Routing;
using Pairme.Models;

namespace Pairme
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Web.Mvc.AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.Add(typeof(IStepViewModel), new StepViewModelBinder());
        }
    }
}
