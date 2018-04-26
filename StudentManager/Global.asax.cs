using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StudentManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//全局过滤器（拦截器）
            RouteConfig.RegisterRoutes(RouteTable.Routes);//注册路由（当前最主要的文件）
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
