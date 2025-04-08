using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecaldeN_Taller1.Models;
using RecaldeN_Taller1.Repositories;

namespace RecaldeN_Taller1.Controllers
{
    public class EquipoController : Controller
    {
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListaRepositories();
            return View(equipos);
        }
    }   
}   
