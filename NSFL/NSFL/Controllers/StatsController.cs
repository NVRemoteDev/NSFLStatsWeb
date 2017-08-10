using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NSFL.Controllers
{
    public class StatsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeamTPE()
        {
            return View();
        }

        public ActionResult PlayerTPE(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}