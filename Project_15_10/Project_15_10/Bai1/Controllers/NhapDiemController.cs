using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XuLy()
        {
            string Ma = Request["Id"];
            string Ten = Request["Name"];
            double Diem = Convert.ToDouble(Request["Marks"]);
            ViewBag.ma = Ma;
            ViewBag.ten = Ten;
            ViewBag.diem = Diem;
            return View();
        }
        
    }
}