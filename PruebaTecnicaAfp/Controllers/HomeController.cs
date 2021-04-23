using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaTecnicaAfp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaAfp.Controllers
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

        public IActionResult numero(int numero)
        {
            try
            {
                string resultado = "";
                if (numero % 3 == 0 & numero % 5 == 0)
                {
                    resultado = "FizzBuzz";
                }
                else if (numero % 3 == 0 & numero % 5 != 0)
                {
                    resultado = "Fizz";
                }
                else if (numero % 5 == 0 & numero % 3 != 0)
                {
                    resultado = "Buzz";
                }
                else if(numero % 3 != 0 & numero % 5 != 0)
                {
                    resultado = "i";
                }
                return Ok(resultado);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
