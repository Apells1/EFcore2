using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Northwind.Models;
namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        // this controller depends on the BloggingRepository
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(b => b.CategoryName));
        // public IActionResult Index2() => View(_northwindContext.Products);

        public IActionResult Index(int id) => View(_northwindContext.Products.Where(p => p.Discontinued == false));
    }
}