using Conversor_de_Monedas.Models;
using Conversor_de_Monedas.Service;
using Microsoft.AspNetCore.Mvc;

namespace Conversor_de_Monedas.Controllers
{
    public class ConversorController : Controller
    {
        private readonly ConversorService conversorService;


        public ConversorController()
        {
            conversorService = new();
        }
        public IActionResult Index()
        {
            return View(new ConversorViewModel());
        }

        [HttpPost]
        public IActionResult Index(ConversorViewModel cvm)
        {
            conversorService.Convertir(cvm);
            return View(cvm);
        }


    }
}
