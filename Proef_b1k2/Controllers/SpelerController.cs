using Proef_b1k2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proef_b1k2.Controllers
{
    public class SpelerController : Controller
    {
        DatabaseContext context = new DatabaseContext();

        public ActionResult Index()
        {
            return View(context.Spelers.ToList());
        }

        public ActionResult Details(int? Id)
        {
            Speler spl = context.Spelers.Where(s => s.SpelerID == Id).FirstOrDefault();
            return View(spl);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Speler speler)
        {
            context.Spelers.Add(speler);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}