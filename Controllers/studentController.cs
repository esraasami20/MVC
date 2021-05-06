using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class studentController : Controller
    {
        public ViewResult Index()
        {
            return View(studentMoc.getStudent());
        }
        public ViewResult addStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addStudent(student std)
        {
            
            studentMoc.addStudent(std);
            return RedirectToAction("Index", studentMoc.getStudent());
        }
        public ActionResult Details(int id)
        {
            return View(studentMoc.studentDetails(id));
        }
        public ActionResult Delete(int id)
        {
            studentMoc.removeStd(id);
            return RedirectToAction("Index", studentMoc.getStudent());
        }

        public ActionResult Update(int id)
        {
            student std = studentMoc.studentDetails(id);
            return View(std);
        }
        [HttpPost]
        public ActionResult Update(int id, string name, int age)
        {
            studentMoc.Edit(new student() { ID = id, Name = name, Age = age });
            return RedirectToAction("Index", studentMoc.getStudent());
        }

    }
}