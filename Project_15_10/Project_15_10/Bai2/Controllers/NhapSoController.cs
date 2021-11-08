using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;

namespace Bai2.Controllers
{
    public class NhapSoController : Controller
    {
        // GET: NhapSo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XuLy(string sa="", string sb="" , string pt ="")
        {

            //Cách 4

            //double kq = 0;
            //if(t.pt == "cong")
            //{
            //    kq = t.sa + t.sb;
            //}
            //if (t.pt == "tru")
            //{
            //    kq = t.sa - t.sb;
            //}
            //if (t.pt == "nhan")
            //{
            //    kq = t.sa * t.sb;
            //}
            //if (t.pt == "chia")
            //{
            //    kq = t.sa / t.sb;
            //}
            //ViewBag.ketqua = kq;


            // Cách 1:

            //double a = Convert.ToDouble(Request["sa"]);
            //double b = Convert.ToDouble(Request["sb"]);
            //string pt = Request["pt"];
            //double kq = 0;
            //if(pt == "cong")
            //{
            //    kq = a + b;
            //}
            //if (pt == "tru")
            //{
            //    kq = a - b;
            //}
            //if (pt == "nhan")
            //{
            //    kq = a * b;
            //}
            //if (pt == "chia")
            //{
            //    kq = a / b;
            //}

            //ViewBag.ketqua = kq;


            //Cách 2:

            //double a = Convert.ToDouble(data["sa"]);
            //double b = Convert.ToDouble(data["sb"]);
            //double kq = 0;
            //string pt = data["pt"];
            //if (pt == "cong")
            //{
            //    kq = a + b;
            //}
            //if (pt == "tru")
            //{
            //    kq = a - b;
            //}
            //if (pt == "nhan")
            //{
            //    kq = a * b;
            //}
            //if (pt == "chia")
            //{
            //    kq = a / b;
            //}
            //ViewBag.ketqua = kq;

            //Cách 3:
            double a = Convert.ToDouble(sa);
            double b = Convert.ToDouble(sb);
            double kq = 0;
            if (pt == "cong")
            {
                kq = a + b;
            }
            if (pt == "tru")
            {
                kq = a - b;
            }
            if (pt == "nhan")
            {
                kq = a * b;
            }
            if (pt == "chia")
            {
                kq = a / b;
            }

            ViewBag.ketqua = kq;

            return View();
        }
    }
}