using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ArtsController : Controller
    {
        private IArtRepository repository;
        public ArtsController(IArtRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Arts);
        }
    }
}