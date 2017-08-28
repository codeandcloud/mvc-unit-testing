using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManager.Web.Controllers
{
    public class FizzBuzzController : Controller
    {
        /// <summary>
        /// Creates a FizzBuzz sequence with specified count.
        /// </summary>
        /// <param name="count">Count of the FizzBuzz sequence.</param>
        /// <returns>Returns FizBuzz sequence with specified count.</returns>
        public ActionResult Index(int count)
        {
            var output = string.Empty;
            for (var i = 1; i <= count; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    output += "FizzBuzz ";
                }
                else if (i % 5 == 0)
                {
                    output += "Buzz ";
                }
                else if (i % 3 == 0)
                {
                    output += "Fizz ";
                }
                else
                {
                    output += i + " ";
                }
            }
            ViewBag.Output = output.Trim();
            return View();
        }
    }
}