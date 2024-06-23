using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_asp.net_core.Data;
using Project_asp.net_core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_asp.net_core.Controllers
{
    public class HomeController : Controller
    {

        private readonly Project_aspnet_coreContext _context;

        public HomeController(Project_aspnet_coreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
