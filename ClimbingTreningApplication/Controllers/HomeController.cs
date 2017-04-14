using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClimbingTreningApplication.Models;

namespace ClimbingTreningApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm (ClimbersResponse climbersResponse)
        {
            if (ModelState.IsValid)
            {
                //todo: email response to the party organizer
                return View("Thanks", climbersResponse);
            } else
            {
                //there is a validation error
                return View();
            }
        }
    }
}