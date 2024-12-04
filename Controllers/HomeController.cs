using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nextinvesting.Data;
using nextinvesting.Models;
using System.Diagnostics;

namespace nextinvesting.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context ,ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View(_context.Investment);
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
