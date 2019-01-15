using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Database2Controller : Controller
    {
        private Context context2 = new Context();
        // GET: Database2
        public ActionResult Index()
        {
            Advertisement adv = new Advertisement()
            {
                tytul = "Moje ogloszenie",
                tresc = "Sprzedam kota. Nr tel: 111-222-333"

            };

            context2.Advertisements.Add(adv);
            context2.SaveChanges();
            return View();
        }

        public ActionResult ListAdv()
        {

            var model = context2.Advertisements.ToList();


            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Advertisement adv)
        {
            adv.Id = Guid.NewGuid();
            context2.Advertisements.Add(adv);
            context2.SaveChanges();

            return RedirectToAction("ListAdv");
        }
    }
}