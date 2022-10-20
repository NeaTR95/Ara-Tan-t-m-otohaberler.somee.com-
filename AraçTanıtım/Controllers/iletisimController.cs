using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracTanitim.Models.Sınıflara;

namespace AracTanitim.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();

        [HttpGet]
        public ActionResult YeniIletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIletisim(iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("/YeniIletisim/iletisim/");
        }
    }
}