using Microsoft.AspNetCore.Mvc;
using U3P4.Models;

namespace U3P4.Controllers
{
    public class CarritoControlador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
