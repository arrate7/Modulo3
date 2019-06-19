using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityWebApp.Models;
using IdentityWebApp.Data;
using Microsoft.AspNetCore.Identity;

namespace IdentityWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<AppUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
                return View(user);

            }

            List<AppUser> users = _userManager.Users.ToList();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
