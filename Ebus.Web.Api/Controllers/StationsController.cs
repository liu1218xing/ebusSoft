﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ebus.Web.Api.Controllers
{
    public class StationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}