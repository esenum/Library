﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class RentalsController : LibraryController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}