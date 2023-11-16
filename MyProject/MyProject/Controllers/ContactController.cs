using Microsoft.AspNetCore.Mvc;
using MyProject.ViewModels;

namespace MyProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactCreate()
        {
            return View();
        }
    }
}
