using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidu.Models;

namespace Vidu.Controllers
{
    public class RarorController : Controller
    {
        // GET: Raror
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(goitinh gt)
        {
            return View(gt);
        }
    }
}