using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]

    public class Admins
    {
        private int adminId;
        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        private string loginId;
        public string LoginId
        {
            get { return loginId; }
            set { loginId = value; }
        }

        private string loginPwd;
        public string LoginPwd
        {
            get { return loginPwd; }
            set { loginPwd = value; }
        }

        private string adminName;
        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
    }
}
