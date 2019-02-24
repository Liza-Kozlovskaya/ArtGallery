using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ArtsController : Controller
    {
        private IArtRepository repository;
        public int pageSize = 5;
        public ArtsController(IArtRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1)
        {
            //разбиение по количеству страниц на 1 странице
            ArtsListViewModel model = new ArtsListViewModel
            {
                Arts = repository.Arts
                .OrderBy(art => art.ArtId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Arts.Count()
                }
            };
            
            return View(model);
        }
    }
}