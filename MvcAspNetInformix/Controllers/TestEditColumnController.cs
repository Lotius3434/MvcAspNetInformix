﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAspNetInformix.Controllers
{
    public class TestEditColumnController : Controller
    {
        // GET: TestEditColumn
        public ActionResult CreateColumn()
        {
            return View();
        }
        public ActionResult UpdateColumn(int id, string surname,string name,string patronymicName)
        {
            return View();
        }
        public ActionResult DeleteColumn()
        {
            return View();
        }
    }
}