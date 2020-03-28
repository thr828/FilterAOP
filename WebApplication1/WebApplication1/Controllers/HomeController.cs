﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{

    [MyActionFilter]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
        
            return View();
        }
        [CustomerException]
        public ActionResult About()
        {
            throw new Exception("xx");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}