using AracTanitim.Models.Sınıflara;
using System.Linq;
using System.Web.Mvc;

namespace AracTanitim.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        Context c = new Context();
        HaberYorum hy = new HaberYorum();
        public ActionResult Index()
        {
            hy.Deger1 = c.Habers.OrderByDescending(x => x.ID).ToList();
            hy.Deger3 = c.Habers.OrderByDescending(x => x.ID).Take(3).ToList();


            return View(hy);
        }

        public ActionResult HaberDetay(int id)
        {
            //var haberbul = c.Habers.Where(x => x.ID == id).ToList();
            hy.Deger1 = c.Habers.Where(x => x.ID == id).ToList();
            hy.Deger2 = c.Yorumlars.Where(x => x.Haberid == id).ToList();
            return View(hy);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}