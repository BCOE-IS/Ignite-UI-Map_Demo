using Ignite_UI_Map_Demo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ignite_UI_Map_Demo.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment env;
        public HomeController(IHostingEnvironment env)
        {
            this.env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PolylineSeries()
        {
            return View();
        }

        public IActionResult BingMap()
        {
            return View();
        }


        public IActionResult OpenStreets()
        {
            return View();
        }

        public IActionResult BindingCollection()
        {
            //  Get the content of the world-cities.js file and extract the array data only
            //  excluding the opening variable declaration

            var jsFileName = Path.Combine(env.WebRootPath, "Cities.js");
            var jsFileContent = System.IO.File.ReadAllText(jsFileName);
            var openingBracePos = jsFileContent.IndexOf('[');
            var closingBracePos = jsFileContent.IndexOf(']');
            var jsonContent = jsFileContent.Substring(openingBracePos, closingBracePos - openingBracePos + 1);

            //  De-serialize WorldCities data from a JavaScript array into List<WorldCity>
            var wordlCities = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorldCity>>(jsonContent);

            return View("BindingCollection", wordlCities.AsQueryable());
        }

        public IActionResult ScatterSeries()
        {
            return View();
        }

        public IActionResult SymbolSeries()
        {
            return View();
        }

        public IActionResult ProportionalSymbolSeries()
        {
            return View();
        }

        public IActionResult ShapesSeries()
        {
            return View();
        }

        public IActionResult AreaSeries()
        {
            return View();
        }

        public IActionResult ContourSeries()
        {
            return View();
        }

        public IActionResult MarkerTemplate()
        {
            return View();
        }
    }

   
}