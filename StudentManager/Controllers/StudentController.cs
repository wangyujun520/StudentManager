using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace StudentManager.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Authorize]
        public ActionResult Index()
        {
            string adminName = this.User.Identity.Name;//获取写入的adminName
            ViewBag.adminName = adminName;//保存数据

            string className = "";

            //调用业务逻辑
            List<Students> stuList = new BLL.StudentManager().GetStudentInfoByClassName(className);
            //保存数据
            ViewBag.className = className;
            ViewBag.stuList = stuList;
            return View("StudentManager");
        }
        [HttpPost]
        public ActionResult GetStuByClassName(string className)
        {
            //获取数据
            //string className = Request.Params["className"];

            //调用业务逻辑
            List<Students> stuList = new BLL.StudentManager().GetStudentInfoByClassName(className);
            //保存数据
            ViewBag.className = className;
            ViewBag.stuList = stuList;
            //返回视图
            return View("StudentManager");
        }

        /// <summary>
        /// 根据学员编号获取学员信息
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        
        public ActionResult GetStuInfoById(int stuId)
        {
            //调用业务逻辑
            Students objStudent = new BLL.StudentManager().GetStuInfoByStuId(stuId);
            //返回视图
            return View("StudentDetail",objStudent);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View("AddStudentInfo");
        }
        [HttpPost]
        public ActionResult AddStuInfo(Students objStudent)
        {
            //获取数据
            //Students objStudent = new Students()
            //{
            //    StudentName = Request.Params["StudentName"],
            //    Gender = Request.Params["Gender"],
            //    Birthday = Convert.ToDateTime(Request.Params["Birthday"]),
            //    StudentIdNo = Request.Params["StudentIdNo"],
            //    CardNo = Request.Params["CardNo"],
            //    PhoneNumber = Request.Params["PhoneNumber"],
            //    StudentAddress = Request.Params["StudentAddress"],
            //    ClassId = Convert.ToInt32(Request.Params["ClassId"])
            //};
            int result = new BLL.StudentManager().AddStuInfo(objStudent);
            if (result>0)
            {
                return Content("<script>alert('新增成功！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
            else
            {
                return Content("<script>alert('新增失败！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
        }
        [HttpGet]
        public ActionResult DeleteStuInfoById(int stuId)
        {
            //调用业务逻辑
            int result = new BLL.StudentManager().DeleteStuById(stuId);
            if (result>0)
            {
                return Content("<script>alert('删除成功！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
            else
            {
                return Content("<script>alert('删除失败！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
        }
        [HttpGet]
        //跳转到修改页面
        public ActionResult UpdateStu(int stuId)
        {
            //调用业务逻辑
            Students objStudent = new BLL.StudentManager().GetStuInfoByStuId(stuId);
            //返回视图
            return View("UpdateStuInfo", objStudent);
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateStuInfo(Students objStudent)
        {
            //获取数据
            //Students objStudent = new Students()
            //{
            //    StudentId = Convert.ToInt32(Request.Params["StudentId"]),
            //    StudentName = Request.Params["StudentName"],
            //    Gender = Request.Params["Gender"],
            //    Birthday = Convert.ToDateTime(Request.Params["Birthday"]),
            //    StudentIdNo = Request.Params["StudentIdNo"],
            //    CardNo = Request.Params["CardNo"],
            //    PhoneNumber = Request.Params["PhoneNumber"],
            //    StudentAddress = Request.Params["StudentAddress"],
            //    ClassId = Convert.ToInt32(Request.Params["ClassId"])
            //};
            int result = new BLL.StudentManager().UpdateStuInfo(objStudent);
            if (result > 0)
            {
                return Content("<script>alert('修改成功！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
            else
            {
                return Content("<script>alert('修改失败！');document.location='" + Url.Action("Index", "Student") + "';</script>");
            }
        }

    }
}