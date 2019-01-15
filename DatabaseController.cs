using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DatabaseController : Controller
    {
        private Context context = new Context();
        // GET: Database
        public ActionResult Index()
        {
           User user = new User()
           {
               imie = "Paulina",
               nazwisko = "Chludzinska",
               e_mail = "p@p.pl",
               login = "Paulina1",
               haslo = "123"
           };
           
            context.Users.Add(user);
            context.SaveChanges();
         
            return View();
        }

        public ActionResult List()
        {
           
            var model = context.Users.ToList();
            

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            user.Id = Guid.NewGuid();
            context.Users.Add(user);
            context.SaveChanges();

            return RedirectToAction("List");
        }

    }
}