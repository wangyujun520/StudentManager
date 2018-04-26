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
    public class StudentService
    {
        /// <summary>
        /// 根据班级名称查询学员信息
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<Students> GetStudentInfoByClassName(string className)
        {
            string sql = $"select StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, Students.ClassId from Students inner join StudentClass on Students.ClassId=StudentClass.ClassId where ClassName like '%{className}%'";

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Students> list = new List<Students>();
            while (objReader.Read())
            {
                list.Add(new Students()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objReader["Birthday"]),
                    StudentIdNo = objReader["StudentIdNo"].ToString(),
                    CardNo = objReader["CardNo"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt32(objReader["ClassId"])
                });
            }
            objReader.Close();
            return list;
        }
        /// <summary>
        /// 根据学号查询学员详细信息
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public Students GetStuInfoByStuId(int stuId)
        {
            string sql = $"select StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, ClassId from Students where StudentId='{stuId}'";

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Students objStudent = null;
            if (objReader.Read())
            {
                objStudent = new Students()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objReader["Birthday"]),
                    StudentIdNo = objReader["StudentIdNo"].ToString(),
                    CardNo = objReader["CardNo"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt32(objReader["ClassId"])
                };
            }
            objReader.Close();
            return objStudent;
        }

        public int AddStuInfo(Students objStudent)
        {
            string sql = $"insert into Students values('{objStudent.StudentName}','{objStudent.Gender}','{objStudent.Birthday.ToString("yyyy-MM-dd HH:mm:ss")}','{objStudent.StudentIdNo}','{objStudent.CardNo}','{objStudent.PhoneNumber}','{objStudent.StudentAddress}','{objStudent.ClassId}')";

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库连接出现异常！具体信息:\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteStuById(int stuId)
        {
            string sql = $"delete from Students where StudentId='{stuId}'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库连接出现异常！具体信息:\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //根据学员ID修改学员信息
        public int UpdateStuInfo(Students objStudent)
        {
            string sql = $"update Students set StudentName='{objStudent.StudentName}', Gender='{objStudent.Gender}', Birthday='{objStudent.Birthday.ToString("yyyy-MM-dd")}', StudentIdNo='{objStudent.StudentIdNo}', CardNo='{objStudent.CardNo}', PhoneNumber='{objStudent.PhoneNumber}', StudentAddress='{objStudent.StudentAddress}', ClassId='{objStudent.ClassId}' where StudentId='{objStudent.StudentId}'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库连接出现异常！具体信息:\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }


    }
}
