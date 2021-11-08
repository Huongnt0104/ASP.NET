using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidu.Models;

namespace Vidu.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(SinhVien sv)
        {
            //ViewBag.Id = "sv01";
            //ViewBag.Name = "Nguyễn Tất Hương";
            //ViewData["Marks"] = 9.5;
            sv.Id = "sv01";
            sv.Name = "Nguyễn Tất Hướng";
            sv.Marks = 9.8;
            return View(sv);
        }
        public ActionResult Xuly(FormCollection data)
        {
            string Ma = data["Id"];
            string Ten = data["Name"];
            double Diem = Convert.ToDouble(data["Marks"]);
            return View();
        }
    }
}