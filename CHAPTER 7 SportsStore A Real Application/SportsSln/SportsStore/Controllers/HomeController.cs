﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;
using System.Linq;
namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository; 
        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public IActionResult Index() => View(repository.Products);
        public ViewResult Index(int productPage = 1)
                                => View(repository.Products
                                .OrderBy(p => p.ProductID)
                                .Skip((productPage - 1) * PageSize)
                                .Take(PageSize));
    }
}
