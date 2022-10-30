using Proef_b1k2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Proef_b1k2.Controllers
{
    public class SchoolController : Controller
    {
        DatabaseContext context = new DatabaseContext();

        public ActionResult Index()
        {
            return View(context.Schools.ToList());
        }
    }
}