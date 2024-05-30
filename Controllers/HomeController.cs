using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PasaHome.Models;
using PasaHome.Models.Data;
using System.Diagnostics;

namespace PasaHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {

            using (PasaContext db = new PasaContext())
            {
                var model = db.Products.ToList();
                return View(model);
            }
        }
        
        public HomeController(ILogger<HomeController> logger) => _logger = logger;

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private readonly PasaContext _context;



    }
}