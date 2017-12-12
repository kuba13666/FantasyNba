using Shop.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            List<PageVM> pagesList;
            return View();
        }
    }
}