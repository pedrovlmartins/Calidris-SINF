﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class PackingController : Controller
    {
        //
        // GET: /Packing/

        public ActionResult Index(string id)
        {
            return View();
        }

    }
}
