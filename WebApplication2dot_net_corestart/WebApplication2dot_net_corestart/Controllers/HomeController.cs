using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2dot_net_corestart.Models;

namespace WebApplication2dot_net_corestart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EmployeeContext ec;

        public HomeController(ILogger<HomeController> logger, EmployeeContext ec)
        {
            _logger = logger;
            this.ec = ec;
        }

        public IActionResult Index()
        {
            List<Employee> l1= ec.Employees.ToList();
            return View(l1);
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(Employee e1)
        {
            ec.Employees.Add(e1);
            ec.SaveChanges();
            return RedirectToAction("Index");
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
