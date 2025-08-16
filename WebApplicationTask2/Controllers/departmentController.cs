using Microsoft.AspNetCore.Mvc;
using WebApplicationTask2.Models;

namespace WebApplicationTask2.Controllers
{
    public class departmentController : Controller
    {
         

        public ViewResult adddepart()
        {
            contextdb contextdb1 = new contextdb();
            List<department> d = contextdb1.departments.ToList();
            return View(d);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
