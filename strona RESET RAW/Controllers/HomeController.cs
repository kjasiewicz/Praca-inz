using strona_RESET_RAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace strona_RESET.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            ViewBag.ActivePage = ActivePageEnum.Home;
            return View();
        }

        [Route("Aktualnosci")]
        public ActionResult News()
        {
            ViewBag.ActivePage = ActivePageEnum.News;
            return View();
        }

        [Route("Aktualnosci/{id}")]
        public ActionResult News(int id)
        {
            ViewBag.ActivePage = ActivePageEnum.News;
            return View("NewsDetails");
        }
        [Route("Galeria")]
        public ActionResult Gallery()
        {
            ViewBag.ActivePage = ActivePageEnum.Home;
            return View();
        }
        [Route("Galeria/{id}")]
        public ActionResult Gallery(int id)
        {
            ViewBag.ActivePage = ActivePageEnum.News;
            return View("GalleryDetails");
        }
    }
}