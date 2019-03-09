using Gallery1.Models;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class HomeController : Controller
    {
        ArtContext db = new ArtContext();
        public int pageSize = 12;

        public ActionResult Index(int? page)
        {
            var arts = db.ArtWorks.Include(a => a.Author).Include(a => a.Type).Include(a=>a.School).Include(a=>a.Location.City.Country);
            return View(arts.ToList().ToPagedList(page ?? 1, pageSize));
            //http://professorweb.ru/my/ASP_NET/gamestore/level1/1_4.php навигация
            //http://professorweb.ru/my/ASP_NET/gamestore/level1/1_6.php каталог    
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}