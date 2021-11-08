using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidu.Models;

namespace Vidu.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(Test t)
        {
            return View(t);
        }
    }
}