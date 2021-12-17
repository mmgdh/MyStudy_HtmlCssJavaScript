using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStudy_HtmlCssJavaScript.Controllers
{
    public class JavaScriptController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Object()
        {
            return View();
        }
    }
}
