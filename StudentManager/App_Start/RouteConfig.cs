using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)//注册路由的静态方法
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//忽略不需要处理的特定请求

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//定义URL规则
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }//匿名类：定义默认的控制器和动作方法，id参数可选
            );
        }
    }
}
