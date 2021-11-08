using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidu.Models;

namespace Vidu.Controllers
{
    public class BaiHocController : Controller
    {
        // GET: BaiHoc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Regis(ThongTin t)
        {
            return View(t);
        }
    }
}