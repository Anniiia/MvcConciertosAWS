using Microsoft.AspNetCore.Mvc;
using MvcConciertosAWS.Models;
using MvcConciertosAWS.Services;

namespace MvcConciertosAWS.Controllers
{
    public class ConciertosController : Controller
    {
        private ServiceConciertos service;

        public ConciertosController(ServiceConciertos service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<Evento> eventos = await this.service.GetEventosAsync();
            return View(eventos);
        }

        public async Task<IActionResult> Categorias()
        {
            List<Categoria> categorias = await this.service.GetCategoriasAsync();

            return View(categorias);
        }

        public async Task<IActionResult> EventosCategorias(int id)
        {

            List<Evento> eventos = await this.service.GetEventosCategoria(id);
            return View(eventos);
        }


    }
}
