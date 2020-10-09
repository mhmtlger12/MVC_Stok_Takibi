using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MVCStokTakibi.Models.Entity;

namespace MVCStokTakibi.Controllers
{
    
    public class UrunlerController : Controller
    {
        // GET: Urunler
        MvcDBStokEntities DB = new MvcDBStokEntities();
        public ActionResult Index()
        {
            var degerler = DB.TBLURUNLER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler1 = (from i in DB.TBLKATEGORILER.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = i.KATEGORIAD,
                                                  Value = i.KATEGORIID.ToString()



                                              }
                                              ).ToList();
            ViewBag.dgr = degerler1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(TBLURUNLER p1)
        {
            DB.TBLURUNLER.Add(p1);
            DB.SaveChanges();
            return View();


        }
    }
}