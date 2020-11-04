using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;
using System;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
    }
}
