using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class DepartmentController : Controller
    {
        public ViewResult Index()
        {
            return View(Dept.getDept());
        }
        public ViewResult addDept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addDept(Department std)
        {
            Dept.addDept(std);
            return RedirectToAction("Index", Dept.getDept());
        }
        public ActionResult Details(int id)
        {
            return View(Dept.deptDetails(id));
        }
        public ActionResult Delete(int id)
        {
            Dept.removeDept(id);
            return RedirectToAction("Index", Dept.getDept());
        }

        public ActionResult Update(int id)
        {
            Department std = Dept.deptDetails(id);
            return View(std);
        }
        [HttpPost]
        public ActionResult Update(int id, string name)
        {
            Dept.Edit(new Department() { ID = id, Name = name });
            return RedirectToAction("Index", Dept.getDept());
        }
    }
}