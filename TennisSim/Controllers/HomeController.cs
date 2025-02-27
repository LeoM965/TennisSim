using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TennisSim.Models;

namespace TennisSim.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

    }
}
