using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KevinPass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KevinPass.Controllers
{
    [Route("[controller]")]
    public class Pc_1Controller : Controller
    {
        private readonly ILogger<Pc_1Controller> _logger;

        public Pc_1Controller(ILogger<Pc_1Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registra()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _logger.LogInformation("Se registró el contacto");
                    ViewData["Message"] = "Se registró la boleta";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al registrar el contacto");
                    ViewData["Message"] = "Error al registrar el contacto: " + ex.Message;
                }
            }
            else
            {
                ViewData["Message"] = "Datos de entrada no válidos";
            }
            return View("Pc");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}