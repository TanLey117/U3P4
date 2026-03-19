using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using U3P4.Models;

namespace U3P4.Controllers
{
    public class CarritoController : Controller
    {
        static List<Producto> productos = new List<Producto>();
        public IActionResult Index()
        {
            return View(productos);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto p)
        {
            List<Producto> productos;

            var data = HttpContext.Session.GetString("productos");

            if (data != null)
                productos = JsonSerializer.Deserialize<List<Producto>>(data);
            else
                productos = new List<Producto>();

            p.Id = productos.Count + 1;
            productos.Add(p);

            HttpContext.Session.SetString("productos", JsonSerializer.Serialize(productos));

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var producto = productos.FirstOrDefault(x => x.Id == id);
            return View(producto);
        }

        [HttpPost]
        public IActionResult Delete(Producto p)
        {
            var producto = productos.FirstOrDefault(x => x.Id == p.Id);

            if (producto != null)
                productos.Remove(producto);

            return RedirectToAction("Index");
        }
    }
}
