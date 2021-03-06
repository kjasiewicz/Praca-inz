﻿using strona_RESET_RAW.Models;
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

        [Route("Aktualnosci/{newsId}", Name = "NewsRoute")]

        public ActionResult News(int newsId)
        {
            ViewBag.ActivePage = ActivePageEnum.News;
            return View("NewsDetails");
        }
        [Route("Galeria")]
        public ActionResult Gallery()
        {
            ViewBag.ActivePage = ActivePageEnum.Gallery;
            return View();
        }

        [Route("Galeria/{id}", Name = "GalleryRoute")]
        public ActionResult Gallery(int id)
        {
            ViewBag.ActivePage = ActivePageEnum.Gallery;
            return View("GalleryDetails");
        }

        [Route("Kontakt")]
        public ActionResult Core()
        {
            ViewBag.ActivePage = ActivePageEnum.Core;
            return View();
        }

        [Route("Projekty")]
        public ActionResult Projects()
        {
            ViewBag.ActivePage = ActivePageEnum.Projects;
            return View();
        }

        [Route("Projekty/{id}", Name = "ProjectRoute")]
        public ActionResult Projects(int id)
        {
            ViewBag.ActivePage = ActivePageEnum.Projects;
            return View("ProjectsDetails");
        }
        [Route("Wydarzenia")]
        public ActionResult Events()
        {
            ViewBag.ActivePage = ActivePageEnum.Events;
            return View();
        }
    }
}