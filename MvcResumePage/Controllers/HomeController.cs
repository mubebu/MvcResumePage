using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcResumePage.Models;

namespace MvcResumePage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ResumeDBEntities db = new ResumeDBEntities();
            var model = db.UserInfo.Find(3);
            return View(model);
        }                
    }
}