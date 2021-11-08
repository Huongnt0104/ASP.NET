using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;

namespace Bai2.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Sinhvien s)
        {
            return View(s);
        }
    }
}