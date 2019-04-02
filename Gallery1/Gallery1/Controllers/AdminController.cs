﻿using Gallery1.Abstract;
using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gallery1.Controllers
{
    public class AdminController : Controller
    {
        ArtContext db = new ArtContext();
        public ActionResult ListArts()
        {
            return View(db.ArtWorks);
        }

        public ViewResult EditArts(int Id)
        {
            ArtWork artWork = db.ArtWorks.FirstOrDefault(a => a.Id == Id);
            return View(artWork);
        }
    }
}