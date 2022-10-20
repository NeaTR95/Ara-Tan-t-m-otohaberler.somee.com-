using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracTanitim.Models.Sınıflara;

namespace AracTanitim.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Habers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniHaber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHaber(Haber p)
        {
            c.Habers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult HaberSil(int id)
        {
            var h = c.Habers.Find(id);
            c.Habers.Remove(h);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult HaberGetir(int id)
        {
            var hb = c.Habers.Find(id);
            return View("HaberGetir", hb);
        }
        public ActionResult HaberGuncelle(Haber h)
        {
            var hbr = c.Habers.Find(h.ID);
            hbr.Aciklama = h.Aciklama;
            hbr.Baslik = h.Baslik;
            hbr.HaberImage = h.HaberImage;
            hbr.Tarih = h.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var h = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(h);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult iletisimListesi()
        {
            var ilt = c.iletisims.ToList();
            return View(ilt);
        }
        public ActionResult iletisimSil(int id)
        {
            var i = c.iletisims.Find(id);
            c.iletisims.Remove(i);
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");
        }
        
    }
}