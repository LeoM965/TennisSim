using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TennisSim.Data;
using TennisSim.Models;
namespace TennisSim.Controllers
{
    public class GameStartController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GameStartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult EnterUsername()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterUsername(UserName userName1)
        {
            if (ModelState.IsValid)
            {
                if (_context.UserNames.Any(u => u.Username == userName1.Username))
                {
                    ModelState.AddModelError("Username", "This username is already taken.");
                    return View(userName1);
                }
                _context.UserNames.Add(userName1);
                _context.SaveChanges();
                HttpContext.Session.SetString("Username", userName1.Username);
                return RedirectToAction("New");
            }
            return View(userName1);
        }
        public IActionResult New()
        {
            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("EnterUsername", "GameStart");
            }
            UserName model = new UserName { Username = username };
            return View(model);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("EnterUsername");
        }
    }

}