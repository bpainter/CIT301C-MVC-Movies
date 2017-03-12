using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Have to manually install this through NuGet
// To use HtmlEncoder on the Mac
using System.Text.Encodings.Web;




namespace movies.Controllers
{
    public class HelloWorldController : Controller
    {
		// What was originally generated
		//public ActionResult Index()
		//{
		//    return View ();
		//}

		// GET: /HelloWorld/
		// Can't get IActionResult to work. can't install the package
		// for Abstractions. Version issue.
		public ActionResult Index()
		{
			return View();
		}


		// GET: HelloWorld/Welcome/
		public ActionResult Welcome(string name, int numTimes = 1)
		{
			//return "Welcome action";
			//return HtmlEncoder.Default.Encode($"Welcome {name}, visits: {numTimes}");

			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;

			return View();
		}

    }
}
