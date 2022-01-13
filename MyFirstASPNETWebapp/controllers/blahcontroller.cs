using Microsoft.AspNetCore.Mvc;
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

        public IActionResult gradeCalc()
        {
            return View();
        }

    }
}
