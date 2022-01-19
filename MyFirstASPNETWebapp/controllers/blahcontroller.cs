using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWebapp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebapp.controllers
{
    public class blahcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult gradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult gradeCalc(gradeCalcModel model)
        {
            return View();
        }

    }
}
