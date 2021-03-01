using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the BloggingRepository
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Index() => View(_northwindContext.Categories);
    }
}