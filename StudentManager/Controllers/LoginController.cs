using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL;
using Models;

namespace StudentManager.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("AdminLogin");
        }

        [HttpPost]
        public ActionResult AdminLogin(Admins objAdmin)
        {
            //保存数据
            ViewBag.LoginId = objAdmin.LoginId;
            ViewBag.LoginPwd = objAdmin.LoginPwd;
            //验证非空
            if (string.IsNullOrEmpty(objAdmin.LoginId))
            {
                ViewBag.info = "用户名不能为空！";
            }
            else if (string.IsNullOrEmpty(objAdmin.LoginPwd))
            {
                ViewBag.info = "密码不能为空！";
            }
            else
            {
                string adminName = new BLL.AdminLoginManager().AdminLogin(objAdmin);
                if (adminName != null)
                {
                    //为当前用户提供一个身份验证票证，并将该票证添加到Cookie
                    FormsAuthentication.SetAuthCookie(adminName, false);

                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    ViewBag.info = "用户名或密码错误！";
                    //返回视图
                    return View();
                }
            }
            return View();
        }


    }
}