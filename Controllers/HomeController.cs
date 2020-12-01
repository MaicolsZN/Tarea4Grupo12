using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaEntityGrupo12.Models;

namespace PracticaEntityGrupo12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {

            return View();
        }

        
        public IActionResult LlamarL()
        {
     
            /*using (PracticaEntityContext db = new PracticaEntityContext())
            {
                 var emplist = db.Empleado.ToList<Empleado>();
              
                     
            }*/

           return View();
        }

        public ActionResult Listado()
        {
            var conec = new PracticaEntityContext();
            var lista = conec.Empleado.ToList();
            return View(lista);
        }

      

        public IActionResult Crear(Empleado oempleado)
        {
            if (ModelState.IsValid)
            {
                PracticaEntityContext conexion = new PracticaEntityContext();
                var oempl = new Empleado { NombreEmpleado = oempleado.NombreEmpleado, SalarioEmpleado = oempleado.SalarioEmpleado, FechaIngresoEmpleado = DateTime.Now };
                conexion.Add<Empleado>(oempl);
                conexion.SaveChanges();

            }
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
