using Microsoft.AspNetCore.Mvc;
using RecaldeN_Taller1.Models;

namespace RecaldeN_Taller1.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipos;

        public EquipoRepository()
        {
            Equipos = DevuelveListaRepositories();
        }


        public IEnumerable<Equipo> DevuelveListaRepositories()
        {
            List<Equipo> equipos = new List<Equipo>();

            equipos.Add(new Equipo { Id = 1, Nombre = "LDU", PartidosJugados = 6, PartidosGanados = 3, PartidosPerdidos = 2, PartidosEmpatados = 1 });
            equipos.Add(new Equipo { Id = 2, Nombre = "Barcelona SC", PartidosJugados = 6, PartidosGanados = 5, PartidosPerdidos = 0, PartidosEmpatados = 1 });
            equipos.Add(new Equipo { Id = 3, Nombre = "U Católica", PartidosJugados = 7, PartidosGanados = 3, PartidosPerdidos = 3, PartidosEmpatados = 1 });
            equipos.Add(new Equipo { Id = 4, Nombre = "Independiente", PartidosJugados = 7, PartidosGanados = 3, PartidosPerdidos = 3, PartidosEmpatados = 1 });

            var listado = equipos.OrderByDescending(item => item.PartidosGanados);
            return listado;
        }
        
        public Equipo DevuelveEquipoPorID(int Id)
        {
            var equipo = Equipos.First(item => item.Id == Id);
            return equipo;
        }        

        public bool ActualizarEquipo(Equipo equipo)
        {
            //Logica de actualizacion
            return true; 
        }
    }
}
