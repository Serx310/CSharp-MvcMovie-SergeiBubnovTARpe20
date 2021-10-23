using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovieTARpe20_SergeiBubnov.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // return HtmlEncoder.Default.Encode($"ID:{id} Hello {name}, NumTimes is: {numTimes}"); 
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
