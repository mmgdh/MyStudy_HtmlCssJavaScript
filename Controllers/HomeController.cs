using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyStudy_HtmlCssJavaScript.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("TestJavaScript");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}