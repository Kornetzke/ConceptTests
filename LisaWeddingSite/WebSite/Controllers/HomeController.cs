﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : AppController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}