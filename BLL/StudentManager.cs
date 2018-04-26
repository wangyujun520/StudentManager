using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using System.Web;

namespace BLL
{
    public class StudentManager
    {
        public List<Students> GetStudentInfoByClassName(string className)
        {
            return new DAL.StudentService().GetStudentInfoByClassName(className);
        }


        public Students GetStuInfoByStuId(int stuId)
        {
            return new DAL.StudentService().GetStuInfoByStuId(stuId);
        }

        public int AddStuInfo(Students objStudent)
        {
            return new DAL.StudentService().AddStuInfo(objStudent);
        }

        public int DeleteStuById(int stuId)
        {
            return new DAL.StudentService().DeleteStuById(stuId);
        }

        public int UpdateStuInfo(Students objStudent)
        {
            return new DAL.StudentService().UpdateStuInfo(objStudent);
        }


    }


}
