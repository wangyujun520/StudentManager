using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DAL;

namespace BLL
{
    public class AdminLoginManager
    {
        private AdminLoginService objAdminService = new AdminLoginService();
        
        public string AdminLogin(Admins objAdmin)
        {
            objAdmin = objAdminService.AdminLogin(objAdmin);
            if (objAdmin!=null)
            {
                HttpContext.Current.Session["CurrentAdmin"] = objAdmin;
                return objAdmin.AdminName;
            }
            else
            {
                return null;
            }
        }
    }
}
