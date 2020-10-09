using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStokTakibi.Models.Entity;

namespace MVCStokTakibi.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDBStokEntities db = new MvcDBStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBLMUSTERILER p1)
        {
            db.TBLMUSTERILER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}