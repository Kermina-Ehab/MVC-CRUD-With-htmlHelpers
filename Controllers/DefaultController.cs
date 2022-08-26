using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDHTNLHELPERS.Models;

namespace CRUDHTNLHELPERS.Controllers
{
    public class DefaultController : Controller
    {
        Model1 md = new Model1(); 
        public ActionResult Index()

        {
            var emps=md.employees.ToList();


            return View(emps);
        }

        [HttpGet]
        public ActionResult create()

        {
            ViewBag.depts = new SelectList(md.Departments.ToList(), "id", "name",2);
            return View();
        }



        [HttpPost]
        public ActionResult Create(Employee emp)

        {
            if (ModelState.IsValid)
            {
                md.employees.Add(emp);
                md.SaveChanges();
               return RedirectToAction("Index");
            }
            


                ViewBag.depts = new SelectList(md.Departments.ToList(), "id", "name", 2);


                return View();
            
        }


        [HttpGet]
        public ActionResult Edit(int id)

        {
              var obj=md.employees.SingleOrDefault(e => e.id == id);

            ViewBag.depts = new SelectList(md.Departments.ToList(), "id", "name", obj.Deptid);

            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)

        {

            if (ModelState.IsValid)
            {

            md.Entry(emp).State = System.Data.Entity.EntityState.Modified;

            md.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public ActionResult delete(int id)

        {
            var obj = md.employees.SingleOrDefault(e => e.id == id);

              md.employees.Remove(obj);
            md.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Emailexists(string Email)
        {
            bool vv=md.employees.Any(ee => ee.Email == Email);
            return Json(!vv, JsonRequestBehavior.AllowGet);
        }
    }
}