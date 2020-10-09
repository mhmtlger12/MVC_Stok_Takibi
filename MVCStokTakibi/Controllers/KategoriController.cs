using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MVCStokTakibi.Models.Entity;
namespace MVCStokTakibi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDBStokEntities db = new MvcDBStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORILER.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORILER P1)

        {
            db.TBLKATEGORILER.Add(P1);
            db.SaveChanges();
            
            return View();
            
        }
    }
}
  