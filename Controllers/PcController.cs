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
    
    public class PcController : Controller
    {
        private readonly ILogger<PcController> _logger;

        public PcController(ILogger<PcController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }







        [HttpPost]
        public IActionResult Calcular(PcModel formulario)
        {
            if (ModelState.IsValid)
            {
                string mensaje = "";
                try
                {
                    mensaje = $"resultado es : {formulario.Operar()}";
                }
                catch (Exception ex)
                {

                    mensaje = "Error en la Ejucion: " + ex.Message;
                }
                    ViewData["Resultado"] = mensaje;
            }
            else
            {
                ViewData["Resultado"] = "Datos no válidos";
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