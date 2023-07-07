using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestEmployeeEF.Models;

namespace TestEmployeeEF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IConfiguration _config;
        EFContext _context = new EFContext();

        public HomeController(ILogger<HomeController> logger,IConfiguration conf)
        {
            _logger = logger;
            _config = conf; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contract()
        {
            List<Contractor> lst = _context.Contractors.ToList();  
            return View(lst);
        }

        public IActionResult Employee()
        {
            List<Employee> lst = _context.Employees.ToList();
            return View(lst);
        }

        public IActionResult EditContractor(int id)
        {
            Contractor data = _context.Contractors.Where(p => p.ContractorId == id).FirstOrDefault();
            
            return View("EditContractor",data);
        }

        [HttpPost]
        public IActionResult EditContractor(Contractor c)
        {
            _context.Contractors.Update(c);
            _context.SaveChanges();
            return RedirectToAction("Contract");
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