using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FantasyNBA.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult New()
        {
            return View();

        }
    }
}