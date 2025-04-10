using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using RecaldeN_Taller1.Models;
using RecaldeN_Taller1.Repositories;

namespace RecaldeN_Taller1.Controllers
{
    public class EquipoController : Controller
    {

        public EquipoRepository _repository;

        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListaRepositories();
            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorID(Id);
            return View(equipo);
        }

        [HttpPost]
        public ActionResult Edit(int id, Equipo equipo)
        {
            //Proceso de guardar
            try
            {
                _repository.ActualizarEquipo(equipo);
                return RedirectToAction(nameof(List));
            }
            catch 
            {
                return View();
            }
        }

        public ActionResult Details(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorID(Id);
            return View(equipo);
        }
       
    }   
}   
