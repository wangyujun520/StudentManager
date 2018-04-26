using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using DAL.Helper;

namespace DAL
{
    public class AdminLoginService
    {
        /// <summary>
        /// 根据用户名和密码登陆
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public Admins AdminLogin(Admins objAdmin)
        {
            string sql = $"select AdminName from Admins where LoginId='{objAdmin.LoginId}' and LoginPwd='{objAdmin.LoginPwd}'";

            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                    objReader.Close();
                }
                else
                {
                    objAdmin = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objAdmin;
        }


    }
}
