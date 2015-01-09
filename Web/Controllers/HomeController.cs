using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TTB_Model;

namespace TTB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<project> model = new List<project>();
            using (var db = new TTBEntities())
            {
                model = (from p in db.projects
                    select p).Include(r => r.rating).Include(s => s.status).ToList();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var model = new List<project>();

            using (var db = new TTBEntities())
            {
                if (name != string.Empty)
                {
                    model = (from p in db.projects
                             where p.projectName.Contains(name)
                             select p).Include(r => r.rating).Include(s => s.status).ToList();
                }
                else
                {
                    model = (from p in db.projects
                             select p).Include(r => r.rating).Include(s => s.status).ToList();
                }
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}